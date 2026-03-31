// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rules which apply to the BPO (Bank Payment Obligation).
    /// </summary>
    [KnownType(typeof(BPOApplicableRules1Choice.URBPOVersion))]
    [KnownType(typeof(BPOApplicableRules1Choice.OtherRulesAndVersion))]
    [JsonDerivedType(
        typeof(BPOApplicableRules1Choice.URBPOVersion),
        nameof(BPOApplicableRules1Choice.URBPOVersion)
    )]
    [JsonDerivedType(
        typeof(BPOApplicableRules1Choice.OtherRulesAndVersion),
        nameof(BPOApplicableRules1Choice.OtherRulesAndVersion)
    )]
    [IsoId("_jjfsgNNqEeKdOs2hjJ_3WQ")]
    [DisplayName("BPO Applicable Rules 1 Choice")]
    public abstract record BPOApplicableRules1Choice_ { }
}
