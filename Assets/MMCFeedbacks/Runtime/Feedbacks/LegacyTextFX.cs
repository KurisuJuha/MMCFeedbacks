﻿using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace MMCFeedbacks.Core
{
    /*[Serializable] public class LegacyTextFX: IFeedback
    {
        public int Order => 8;
        public bool IsActive { get; set; } = true;
        public FeedbackState State { get; private set; }
        public string MenuString => "UI/Legacy Text";
        public Color TagColor => FeedbackStyling.UIFXColor;

        [SerializeField] private Timing timing;
        [SerializeField] private bool ignoreTimeScale;
        [Space(10)]
        [SerializeField] private Text target;
        [Header("Text")]
        [SerializeField] private ScrambleMode scrambleMode;
        [SerializeField] private EaseMode mode;
        [SerializeField,DisplayIf(nameof(mode),(int)EaseMode.Ease)] private Ease ease=Ease.Linear;
        [SerializeField,DisplayIf(nameof(mode),(int)EaseMode.Curve)]
        [NormalizedAnimationCurve(false)] private AnimationCurve curve=AnimationCurve.Linear(0,0,1,1);
        [SerializeField] private float duration=1;

        [SerializeField, TextArea] private string zero;
        [SerializeField, TextArea] private string one;

        private Tween _tween;
        private CancellationTokenSource _cancellationTokenSource;
        public void OnDestroy()
        {
            _cancellationTokenSource?.Cancel();
        }
        public void Play()
        {
            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource = new();
            _tween?.Kill();
            State = FeedbackState.Pending;
            PlayAsync().Forget();
        }

        public void Stop()
        {
            _tween.Pause();
        }
        private async UniTaskVoid PlayAsync()
        {
            await UniTask.Delay(TimeSpan.FromSeconds(timing.delayTime),cancellationToken:_cancellationTokenSource.Token);
            State = FeedbackState.Running;

            _tween = target.DOText(one, duration, true, scrambleMode)
                .From(zero)
                .SetUpdate(ignoreTimeScale)
                .OnComplete(() => State = FeedbackState.Completed);
            if (mode == EaseMode.Ease) 
                _tween.SetEase(ease);
            else 
                _tween.SetEase(curve);

        }
    }*/
}