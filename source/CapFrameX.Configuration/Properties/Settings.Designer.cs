﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapFrameX.Configuration.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int MovingAverageWindowSize {
            get {
                return ((int)(this["MovingAverageWindowSize"]));
            }
            set {
                this["MovingAverageWindowSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int IntervalAverageWindowTime {
            get {
                return ((int)(this["IntervalAverageWindowTime"]));
            }
            set {
                this["IntervalAverageWindowTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2.5")]
        public double StutteringFactor {
            get {
                return ((double)(this["StutteringFactor"]));
            }
            set {
                this["StutteringFactor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MyDocuments\\CapFrameX\\Captures")]
        public string ObservedDirectory {
            get {
                return ((string)(this["ObservedDirectory"]));
            }
            set {
                this["ObservedDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int FpsValuesRoundingDigits {
            get {
                return ((int)(this["FpsValuesRoundingDigits"]));
            }
            set {
                this["FpsValuesRoundingDigits"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowLowParameter {
            get {
                return ((bool)(this["ShowLowParameter"]));
            }
            set {
                this["ShowLowParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MyDocuments\\CapFrameX\\Screenshots")]
        public string ScreenshotDirectory {
            get {
                return ((string)(this["ScreenshotDirectory"]));
            }
            set {
                this["ScreenshotDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordMaxStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordMaxStatisticParameter"]));
            }
            set {
                this["UseSingleRecordMaxStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordP99QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP99QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP99QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP95QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP95QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP95QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordAverageStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordAverageStatisticParameter"]));
            }
            set {
                this["UseSingleRecordAverageStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP5QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP5QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP5QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP1QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP1QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP1QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordP0Dot1QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP0Dot1QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP0Dot1QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordP1LowAverageStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP1LowAverageStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP1LowAverageStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordP0Dot1LowAverageStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP0Dot1LowAverageStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP0Dot1LowAverageStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordMinStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordMinStatisticParameter"]));
            }
            set {
                this["UseSingleRecordMinStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordAdaptiveSTDStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordAdaptiveSTDStatisticParameter"]));
            }
            set {
                this["UseSingleRecordAdaptiveSTDStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("F11")]
        public string CaptureHotKey {
            get {
                return ((string)(this["CaptureHotKey"]));
            }
            set {
                this["CaptureHotKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("voice response")]
        public string HotkeySoundMode {
            get {
                return ((string)(this["HotkeySoundMode"]));
            }
            set {
                this["HotkeySoundMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double CaptureTime {
            get {
                return ((double)(this["CaptureTime"]));
            }
            set {
                this["CaptureTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP0Dot2QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP0Dot2QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP0Dot2QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.25")]
        public double VoiceSoundLevel {
            get {
                return ((double)(this["VoiceSoundLevel"]));
            }
            set {
                this["VoiceSoundLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        public double SimpleSoundLevel {
            get {
                return ((double)(this["SimpleSoundLevel"]));
            }
            set {
                this["SimpleSoundLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P1")]
        public string SecondMetric {
            get {
                return ((string)(this["SecondMetric"]));
            }
            set {
                this["SecondMetric"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P0dot2")]
        public string ThirdMetric {
            get {
                return ((string)(this["ThirdMetric"]));
            }
            set {
                this["ThirdMetric"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CPU")]
        public string ComparisonContext {
            get {
                return ((string)(this["ComparisonContext"]));
            }
            set {
                this["ComparisonContext"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GameName")]
        public string RecordingListSortMemberPath {
            get {
                return ((string)(this["RecordingListSortMemberPath"]));
            }
            set {
                this["RecordingListSortMemberPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ascending")]
        public string RecordingListSortDirection {
            get {
                return ((string)(this["RecordingListSortDirection"]));
            }
            set {
                this["RecordingListSortDirection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        public string SyncRangeLower {
            get {
                return ((string)(this["SyncRangeLower"]));
            }
            set {
                this["SyncRangeLower"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("120")]
        public string SyncRangeUpper {
            get {
                return ((string)(this["SyncRangeUpper"]));
            }
            set {
                this["SyncRangeUpper"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowOutlierWarning {
            get {
                return ((bool)(this["ShowOutlierWarning"]));
            }
            set {
                this["ShowOutlierWarning"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Auto")]
        public string HardwareInfoSource {
            get {
                return ((string)(this["HardwareInfoSource"]));
            }
            set {
                this["HardwareInfoSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CPU")]
        public string CustomCpuDescription {
            get {
                return ((string)(this["CustomCpuDescription"]));
            }
            set {
                this["CustomCpuDescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GPU")]
        public string CustomGpuDescription {
            get {
                return ((string)(this["CustomGpuDescription"]));
            }
            set {
                this["CustomGpuDescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("RAM")]
        public string CustomRamDescription {
            get {
                return ((string)(this["CustomRamDescription"]));
            }
            set {
                this["CustomRamDescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt+O")]
        public string OverlayHotKey {
            get {
                return ((string)(this["OverlayHotKey"]));
            }
            set {
                this["OverlayHotKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsOverlayActive {
            get {
                return ((bool)(this["IsOverlayActive"]));
            }
            set {
                this["IsOverlayActive"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt+R")]
        public string ResetHistoryHotkey {
            get {
                return ((string)(this["ResetHistoryHotkey"]));
            }
            set {
                this["ResetHistoryHotkey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseRunHistory {
            get {
                return ((bool)(this["UseRunHistory"]));
            }
            set {
                this["UseRunHistory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P1")]
        public string SecondMetricOverlay {
            get {
                return ((string)(this["SecondMetricOverlay"]));
            }
            set {
                this["SecondMetricOverlay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P0dot2")]
        public string ThirdMetricOverlay {
            get {
                return ((string)(this["ThirdMetricOverlay"]));
            }
            set {
                this["ThirdMetricOverlay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseAggregation {
            get {
                return ((bool)(this["UseAggregation"]));
            }
            set {
                this["UseAggregation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int SelectedHistoryRuns {
            get {
                return ((int)(this["SelectedHistoryRuns"]));
            }
            set {
                this["SelectedHistoryRuns"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Replace")]
        public string OutlierHandling {
            get {
                return ((string)(this["OutlierHandling"]));
            }
            set {
                this["OutlierHandling"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int OSDRefreshPeriod {
            get {
                return ((int)(this["OSDRefreshPeriod"]));
            }
            set {
                this["OSDRefreshPeriod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int OutlierPercentageOverlay {
            get {
                return ((int)(this["OutlierPercentageOverlay"]));
            }
            set {
                this["OutlierPercentageOverlay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Second")]
        public string RelatedMetricOverlay {
            get {
                return ((string)(this["RelatedMetricOverlay"]));
            }
            set {
                this["RelatedMetricOverlay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int InputLagOffset {
            get {
                return ((int)(this["InputLagOffset"]));
            }
            set {
                this["InputLagOffset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P1")]
        public string SecondMetricAggregation {
            get {
                return ((string)(this["SecondMetricAggregation"]));
            }
            set {
                this["SecondMetricAggregation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P0dot2")]
        public string ThirdMetricAggregation {
            get {
                return ((string)(this["ThirdMetricAggregation"]));
            }
            set {
                this["ThirdMetricAggregation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Second")]
        public string RelatedMetricAggregation {
            get {
                return ((string)(this["RelatedMetricAggregation"]));
            }
            set {
                this["RelatedMetricAggregation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int OutlierPercentageAggregation {
            get {
                return ((int)(this["OutlierPercentageAggregation"]));
            }
            set {
                this["OutlierPercentageAggregation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AreThresholdsReversed {
            get {
                return ((bool)(this["AreThresholdsReversed"]));
            }
            set {
                this["AreThresholdsReversed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MyDocuments\\CapFrameX\\Captures\\Cloud")]
        public string CloudDownloadDirectory {
            get {
                return ((string)(this["CloudDownloadDirectory"]));
            }
            set {
                this["CloudDownloadDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MyDocuments\\CapFrameX\\Captures")]
        public string CaptureRootDirectory {
            get {
                return ((string)(this["CaptureRootDirectory"]));
            }
            set {
                this["CaptureRootDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShareProcessListEntries {
            get {
                return ((bool)(this["ShareProcessListEntries"]));
            }
            set {
                this["ShareProcessListEntries"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoUpdateProcessList {
            get {
                return ((bool)(this["AutoUpdateProcessList"]));
            }
            set {
                this["AutoUpdateProcessList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSensorLogging {
            get {
                return ((bool)(this["UseSensorLogging"]));
            }
            set {
                this["UseSensorLogging"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AreThresholdsPercentage {
            get {
                return ((bool)(this["AreThresholdsPercentage"]));
            }
            set {
                this["AreThresholdsPercentage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int OverlayEntryConfigurationFile {
            get {
                return ((int)(this["OverlayEntryConfigurationFile"]));
            }
            set {
                this["OverlayEntryConfigurationFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("250")]
        public int SensorLoggingRefreshPeriod {
            get {
                return ((int)(this["SensorLoggingRefreshPeriod"]));
            }
            set {
                this["SensorLoggingRefreshPeriod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowThresholdTimes {
            get {
                return ((bool)(this["ShowThresholdTimes"]));
            }
            set {
                this["ShowThresholdTimes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SaveAggregationOnly {
            get {
                return ((bool)(this["SaveAggregationOnly"]));
            }
            set {
                this["SaveAggregationOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordMedianStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordMedianStatisticParameter"]));
            }
            set {
                this["UseSingleRecordMedianStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GPU")]
        public string SecondComparisonContext {
            get {
                return ((string)(this["SecondComparisonContext"]));
            }
            set {
                this["SecondComparisonContext"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Json")]
        public string CaptureFileMode {
            get {
                return ((string)(this["CaptureFileMode"]));
            }
            set {
                this["CaptureFileMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordCpuFpsPerWattParameter {
            get {
                return ((bool)(this["UseSingleRecordCpuFpsPerWattParameter"]));
            }
            set {
                this["UseSingleRecordCpuFpsPerWattParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordGpuFpsPerWattParameter {
            get {
                return ((bool)(this["UseSingleRecordGpuFpsPerWattParameter"]));
            }
            set {
                this["UseSingleRecordGpuFpsPerWattParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool StartMinimized {
            get {
                return ((bool)(this["StartMinimized"]));
            }
            set {
                this["StartMinimized"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Autostart {
            get {
                return ((bool)(this["Autostart"]));
            }
            set {
                this["Autostart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Average")]
        public string FirstMetric {
            get {
                return ((string)(this["FirstMetric"]));
            }
            set {
                this["FirstMetric"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsGpuAccelerationActive {
            get {
                return ((bool)(this["IsGpuAccelerationActive"]));
            }
            set {
                this["IsGpuAccelerationActive"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public double StutteringThreshold {
            get {
                return ((double)(this["StutteringThreshold"]));
            }
            set {
                this["StutteringThreshold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt+C")]
        public string OverlayConfigHotKey {
            get {
                return ((string)(this["OverlayConfigHotKey"]));
            }
            set {
                this["OverlayConfigHotKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoDisableOverlay {
            get {
                return ((bool)(this["AutoDisableOverlay"]));
            }
            set {
                this["AutoDisableOverlay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ToggleGlobalRTSSOSD {
            get {
                return ((bool)(this["ToggleGlobalRTSSOSD"]));
            }
            set {
                this["ToggleGlobalRTSSOSD"] = value;
            }
        }
    }
}
