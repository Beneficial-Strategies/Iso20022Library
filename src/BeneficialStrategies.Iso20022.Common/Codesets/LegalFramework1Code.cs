// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the legal framework of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ad1149p-Ed-ak6NoX_4Aeg_-712964613")]
[Description(@"Identifies the legal framework of the transaction.")]
[DerivedFrom(typeof(LegalFrameworkCode))]
public enum LegalFramework1Code
{
    /// <summary>
    /// Relates to the French legal framework for repos, that is, relates to a &quot;Pension Livrée&quot;.
    /// Encoded/decoded by serializers as &quot;FRAN&quot;.
    /// </summary>
    [EnumMember(Value = "FRAN")]
    [IsoId("_ad115Np-Ed-ak6NoX_4Aeg_-1247950171")]
    [Description(@"Relates to the French legal framework for repos, that is, relates to a ""Pension Livrée"".")]
    PensionLivree = LegalFrameworkCode.PensionLivree, // same ordinal as derivation source for type conversions
    
}
