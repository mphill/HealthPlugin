﻿using System;

namespace Plugin.Health
{
    [Preserve(AllMembers = true)]
    public class HealthData
    {
        public DateTime StartDate   { get; set; }
        public DateTime EndDate     { get; set; }
        public double   Value       { get; set; }
        public bool     UserEntered { get; set; }
    }

    public enum AggregateTime
    {
        None,
        Year,
        Month,
        Week,
        Day,
        Hour,
        Minute
    }

    /// <summary>
    /// CumulativeSum is not supported by all HealthDatatypes.
    /// When not supported will Fallback to Average
    /// </summary>
    public enum AggregateType
    {
        None,
        CumulativeSum,
        Average,
        Min,
        Max
    }

    [Preserve(AllMembers = true)]
    public enum HealthDataType
    {
        StepCount,
        Distance,
        HeartRate,
        Height,
        Weight,
        Energy,
        Water,
        BodyFat,
        BodyMassIndex,
        ActiveEnergyBurned,
        BodyTemperature,
        BloodPressureSystolic,
        BloodPressureDiastolic,
        BloodOxygen,
        BloodGlucose,

        iOS_WalkingHeartRate,
        iOS_RestingHeartRate,
        iOS_BasalEnergyBurned,
        iOS_WaistCircumference,
        iOS_StandTime,
        iOS_ExerciseTime
    }
}