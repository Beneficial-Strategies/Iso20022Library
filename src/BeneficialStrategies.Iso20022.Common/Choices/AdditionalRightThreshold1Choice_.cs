// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of additional right threshold.
    /// </summary>
    [KnownType(typeof(AdditionalRightThreshold1Choice.AdditionalRightThreshold))]
    [KnownType(typeof(AdditionalRightThreshold1Choice.AdditionalRightThresholdPercentage))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AdditionalRightThreshold1Choice.AdditionalRightThreshold),nameof(AdditionalRightThreshold1Choice.AdditionalRightThreshold))]
    [JsonDerivedType(typeof(AdditionalRightThreshold1Choice.AdditionalRightThresholdPercentage),nameof(AdditionalRightThreshold1Choice.AdditionalRightThresholdPercentage))]
    #endif
    [IsoId("_RDrok9p-Ed-ak6NoX_4Aeg_1316358552")]
    [DisplayName("Additional Right Threshold 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdditionalRightThreshold1Choice_
    #else
    public abstract partial class AdditionalRightThreshold1Choice_
    #endif
    {
    }
}
