// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the collateral proposal response is an initial or a counter proposal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YbwCU9p-Ed-ak6NoX_4Aeg_-89224518")]
[Description(@"Specifies if the collateral proposal response is an initial or a counter proposal.")]
[DerivedFrom(typeof(CollateralProposalResponseCode))]
public enum CollateralProposalResponse1Code
{
    /// <summary>
    /// Indicates that the collateral proposal response is an initial proposal.
    /// Encoded/decoded by serializers as &quot;INPR&quot;.
    /// </summary>
    [EnumMember(Value = "INPR")]
    [IsoId("_YbwCVNp-Ed-ak6NoX_4Aeg_542981423")]
    [Description(@"Indicates that the collateral proposal response is an initial proposal.")]
    InitialProposal = CollateralProposalResponseCode.InitialProposal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the collateral proposal response is a counter proposal.
    /// Encoded/decoded by serializers as &quot;COPR&quot;.
    /// </summary>
    [EnumMember(Value = "COPR")]
    [IsoId("_YbwCVdp-Ed-ak6NoX_4Aeg_531882646")]
    [Description(@"Indicates that the collateral proposal response is a counter proposal.")]
    CounterProposal = CollateralProposalResponseCode.CounterProposal, // same ordinal as derivation source for type conversions
}
