// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the choice between the major categories of repurchase agreement.
    /// </summary>
    [KnownType(typeof(RepurchaseAgreementType1Choice.SpecificCollateral))]
    [KnownType(typeof(RepurchaseAgreementType1Choice.GeneralCollateral))]
    [JsonDerivedType(
        typeof(RepurchaseAgreementType1Choice.SpecificCollateral),
        nameof(RepurchaseAgreementType1Choice.SpecificCollateral)
    )]
    [JsonDerivedType(
        typeof(RepurchaseAgreementType1Choice.GeneralCollateral),
        nameof(RepurchaseAgreementType1Choice.GeneralCollateral)
    )]
    [IsoId("_3-Tf4LbqEeaqL_M7XFD7PQ")]
    [DisplayName("Repurchase Agreement Type 1 Choice")]
    public abstract record RepurchaseAgreementType1Choice_ { }
}
