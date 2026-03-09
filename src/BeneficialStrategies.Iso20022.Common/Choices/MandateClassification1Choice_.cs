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
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    [KnownType(typeof(MandateClassification1Choice.Code))]
    [KnownType(typeof(MandateClassification1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MandateClassification1Choice.Code),nameof(MandateClassification1Choice.Code))]
    [JsonDerivedType(typeof(MandateClassification1Choice.Proprietary),nameof(MandateClassification1Choice.Proprietary))]
    #endif
    [IsoId("_JThtg2oDEearR-CA7eRZXQ")]
    [DisplayName("Mandate Classification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MandateClassification1Choice_
    #else
    public abstract partial class MandateClassification1Choice_
    #endif
    {
    }
}
