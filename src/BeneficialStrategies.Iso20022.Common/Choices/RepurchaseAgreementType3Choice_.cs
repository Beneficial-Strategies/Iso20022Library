// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of repurchase agreement.
    /// </summary>
    [KnownType(typeof(RepurchaseAgreementType3Choice.SpecificCollateral))]
    [KnownType(typeof(RepurchaseAgreementType3Choice.GeneralCollateral))]
    [JsonDerivedType(
        typeof(RepurchaseAgreementType3Choice.SpecificCollateral),
        nameof(RepurchaseAgreementType3Choice.SpecificCollateral)
    )]
    [JsonDerivedType(
        typeof(RepurchaseAgreementType3Choice.GeneralCollateral),
        nameof(RepurchaseAgreementType3Choice.GeneralCollateral)
    )]
    [IsoId("_BgUqseoaEeadseq5W5YLvQ")]
    [DisplayName("Repurchase Agreement Type 3 Choice")]
    public abstract record RepurchaseAgreementType3Choice_ { }
}
