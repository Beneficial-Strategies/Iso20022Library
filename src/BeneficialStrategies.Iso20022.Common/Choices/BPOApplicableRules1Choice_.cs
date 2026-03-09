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
    /// Rules which apply to the BPO (Bank Payment Obligation).
    /// </summary>
    [KnownType(typeof(BPOApplicableRules1Choice.URBPOVersion))]
    [KnownType(typeof(BPOApplicableRules1Choice.OtherRulesAndVersion))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BPOApplicableRules1Choice.URBPOVersion),nameof(BPOApplicableRules1Choice.URBPOVersion))]
    [JsonDerivedType(typeof(BPOApplicableRules1Choice.OtherRulesAndVersion),nameof(BPOApplicableRules1Choice.OtherRulesAndVersion))]
    #endif
    [IsoId("_jjfsgNNqEeKdOs2hjJ_3WQ")]
    [DisplayName("BPO Applicable Rules 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BPOApplicableRules1Choice_
    #else
    public abstract partial class BPOApplicableRules1Choice_
    #endif
    {
    }
}
