﻿using System.Threading.Tasks;

namespace Plugin.Health
{
    [Preserve(AllMembers = true)]
    public interface IHealthService
    {
        /// <summary>
        /// Check is HealthKit/Googlefit are available
        /// </summary>
        /// <returns></returns>
        bool IsAvailable();

        /// <summary>
        /// Check if the HealthDataType is supported by the platform
        /// </summary>
        /// <param name="healthDataType">HealthDataType to check</param>
        bool IsDataTypeAvailable(HealthDataType healthDataType);

        /// <summary>
        /// Request permission di read the requested HealthDataTypes
        /// </summary>
        /// <param name="dataTypes">HealthDataTypes to check</param>
        /// <returns></returns>
        Task<bool> RequestPermissionAsync(HealthDataType[] writeDataTypes, HealthDataType[] readDataTypes);

        /// <summary>
        /// Instantiate the DataReader for HealthKit/GoogleFit
        /// </summary>
        /// <returns></returns>
        IHealthDataReader DataReader();

        /// <summary>
        /// Instantiate the DataReader for HealthKit/GoogleFit
        /// </summary>
        /// <returns></returns>
        IHealthDataWriter DataWriter();

        //Platforms
        void PromptInstallGoogleFit();
    }
}
