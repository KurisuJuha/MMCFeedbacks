﻿using System;
using DG.Tweening;
using MMCFeedbacks.Core;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace MMCFeedbacks.Core
{
    [Serializable]
    public class FloatTweenParameter : TweenParameter
    {
        [SerializeField] private EaseMode mode;
        [SerializeField,DisplayIf(nameof(mode),(int)EaseMode.Ease)] private Ease ease=Ease.Linear;
        [SerializeField,DisplayIf(nameof(mode),(int)EaseMode.Curve)]
        [NormalizedAnimationCurve(false)] private AnimationCurve curve=AnimationCurve.Linear(0,0,1,1);
        [SerializeField] private float zero=1;
        [SerializeField] private float one;
        [SerializeField] private float duration=1;
        
        public Tween DoTween(bool ignoreTimeScale,TweenCallback<float> callback)
        {
            if (!IsActive) return null;
            var tween = DOVirtual.Float(zero, one, duration, callback)
                .SetUpdate(ignoreTimeScale);
            if (mode == EaseMode.Ease) 
                tween.SetEase(ease);
            else 
                tween.SetEase(curve);
            
            return tween;
        }
        public FloatTweenParameter(bool showActiveBox=false) => ShowActiveBox = showActiveBox;

        public FloatTweenParameter(bool isActive,bool showActiveBox=false)
        {
            IsActive = isActive;
            ShowActiveBox = showActiveBox;
        }
        public FloatTweenParameter(FloatTweenParameter parameter)
        {
            IsActive = parameter.IsActive;
            mode = parameter.mode;
            ease = parameter.ease;
            curve = parameter.curve;
            zero = parameter.zero;
            one = parameter.one;
            duration = parameter.duration;
        }
    }

    public enum EaseMode
    {
        Ease,
        Curve
    }
}