using UnityEngine;
using Sirenix.OdinInspector;

namespace Sources.Runtime.Gameplay.Configs
{
    [System.Serializable]
    public class UIConfig
    {
        [Title("Fishing Mini Game UI")]

        [SerializeField, LabelText("Pointer Move Duration"), MinValue(0f)]
        private float _fishingPointerMoveDuration = 2.45f;
        public float FishingPointerMoveDuration => _fishingPointerMoveDuration;

        [SerializeField, LabelText("Fishes Move Speed"), MinValue(0f)]
        private float _fishesMoveSpeed = 0.25f;
        public float FishesMoveSpeed => _fishesMoveSpeed;

        [SerializeField, LabelText("Show Delay Between Items"), MinValue(0f)]
        private float _fishingShowDelayBetweenItems = 0.225f;
        public float FishingShowDelayBetweenItems => _fishingShowDelayBetweenItems;

        [SerializeField, LabelText("Fade Duration"), MinValue(0f)]
        private float _fishingFadeDuration = 0.55f;
        public float FishingFadeDuration => _fishingFadeDuration;

        [SerializeField, LabelText("Click Cooldown"), MinValue(0f)]
        private float _fishingClickCooldown = 0.1f;
        public float FishingClickCooldown => _fishingClickCooldown;

        [Space(17.5f)]

        [SerializeField, LabelText("Slider Time To Max"), MinValue(0f)]
        private float _sliderTimeToMaxValue = 1f;
        public float SliderTimeToMaxValue => _sliderTimeToMaxValue;

        [SerializeField, LabelText("Value On Common Catch"), MinValue(0f)]
        private float _valueToAddOnCommonCatch = 10f;
        public float ValueToAddOnCommonCatch => _valueToAddOnCommonCatch;

        [SerializeField, LabelText("Value On Gold Catch"), MinValue(0f)]
        private float _valueToAddOnGoldCatch = 15f;
        public float ValueToAddOnGoldCatch => _valueToAddOnGoldCatch;

        [SerializeField, LabelText("Value On Miss"), MinValue(0f)]
        private float _valueToRemoveOnMiss = 25f;
        public float ValueToRemoveOnMiss => _valueToRemoveOnMiss;

        [Space(17.5f)]
        [Title("Stamina UI")]

        [SerializeField, LabelText("Stamina Fill Duration"), MinValue(0f)]
        private float _staminaFillDuration = 2f;
        public float StaminaFillDuration => _staminaFillDuration;

        [SerializeField, LabelText("Stamina Drain Duration"), MinValue(0f)]
        private float _staminaDrainDuration = 2.5f;
        public float StaminaDrainDuration => _staminaDrainDuration;
    }
}