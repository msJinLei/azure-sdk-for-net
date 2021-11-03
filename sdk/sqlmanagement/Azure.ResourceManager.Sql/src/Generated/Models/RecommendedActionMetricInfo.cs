// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace SqlManagementClient.Models
{
    /// <summary> Contains time series of various impacted metrics for an Azure SQL Database, Server or Elastic Pool Recommended Action. </summary>
    public partial class RecommendedActionMetricInfo
    {
        /// <summary> Initializes a new instance of RecommendedActionMetricInfo. </summary>
        internal RecommendedActionMetricInfo()
        {
        }

        /// <summary> Initializes a new instance of RecommendedActionMetricInfo. </summary>
        /// <param name="metricName"> Gets the name of the metric. e.g., CPU, Number of Queries. </param>
        /// <param name="unit"> Gets the unit in which metric is measured. e.g., DTU, Frequency. </param>
        /// <param name="timeGrain"> Gets the duration of time interval for the value given by this MetricInfo. e.g., PT1H (1 hour). </param>
        /// <param name="startTime"> Gets the start time of time interval given by this MetricInfo. </param>
        /// <param name="value"> Gets the value of the metric in the time interval given by this MetricInfo. </param>
        internal RecommendedActionMetricInfo(string metricName, string unit, string timeGrain, DateTimeOffset? startTime, double? value)
        {
            MetricName = metricName;
            Unit = unit;
            TimeGrain = timeGrain;
            StartTime = startTime;
            Value = value;
        }

        /// <summary> Gets the name of the metric. e.g., CPU, Number of Queries. </summary>
        public string MetricName { get; }
        /// <summary> Gets the unit in which metric is measured. e.g., DTU, Frequency. </summary>
        public string Unit { get; }
        /// <summary> Gets the duration of time interval for the value given by this MetricInfo. e.g., PT1H (1 hour). </summary>
        public string TimeGrain { get; }
        /// <summary> Gets the start time of time interval given by this MetricInfo. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> Gets the value of the metric in the time interval given by this MetricInfo. </summary>
        public double? Value { get; }
    }
}
