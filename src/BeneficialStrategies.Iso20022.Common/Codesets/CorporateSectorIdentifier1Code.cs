// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the corporate sector of the counterparty for reporting to trade repositories.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gj0acFBdEeOenoknK_-H2g")]
[Description(
    @"Identifies the corporate sector of the counterparty for reporting to trade repositories."
)]
[DerivedFrom(typeof(CorporateSectorIdentifierCode))]
public enum CorporateSectorIdentifier1Code
{
    /// <summary>
    /// Alternative investment fund managed by an Alternative Investment Fund Manager (AIFM) authorised or registered in accordance with European Securities and Markets Authority (ESMA) Directive 2011/61/EU.
    /// Encoded/decoded by serializers as &quot;L&quot;.
    /// </summary>
    [EnumMember(Value = "L")]
    [IsoId("_h9rJUVBdEeOenoknK_-H2g")]
    [Description(
        @"Alternative investment fund managed by an Alternative Investment Fund Manager (AIFM) authorised or registered in accordance with European Securities and Markets Authority (ESMA) Directive 2011/61/EU."
    )]
    AlternativeInvestmentFund = CorporateSectorIdentifierCode.AlternativeInvestmentFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Assurance undertaking authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2002/83/EC.
    /// Encoded/decoded by serializers as &quot;A&quot;.
    /// </summary>
    [EnumMember(Value = "A")]
    [IsoId("_iEFTUVBdEeOenoknK_-H2g")]
    [Description(
        @"Assurance undertaking authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2002/83/EC."
    )]
    Assurance = CorporateSectorIdentifierCode.Assurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit Institution authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2006/48/EC.
    /// Encoded/decoded by serializers as &quot;C&quot;.
    /// </summary>
    [EnumMember(Value = "C")]
    [IsoId("_iKonQVBdEeOenoknK_-H2g")]
    [Description(
        @"Credit Institution authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2006/48/EC."
    )]
    CreditInstitution = CorporateSectorIdentifierCode.CreditInstitution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insurance undertaking in accordance with European Securities and Markets Authority (ESMA) Directive 73/239/EEC.
    /// Encoded/decoded by serializers as &quot;I&quot;.
    /// </summary>
    [EnumMember(Value = "I")]
    [IsoId("_iQJZYVBdEeOenoknK_-H2g")]
    [Description(
        @"Insurance undertaking in accordance with European Securities and Markets Authority (ESMA) Directive 73/239/EEC."
    )]
    Insurance = CorporateSectorIdentifierCode.Insurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment firm in accordance with European Securities and Markets Authority (ESMA) Directive 2004/39/EC.
    /// Encoded/decoded by serializers as &quot;F&quot;.
    /// </summary>
    [EnumMember(Value = "F")]
    [IsoId("_iXc7QVBdEeOenoknK_-H2g")]
    [Description(
        @"Investment firm in accordance with European Securities and Markets Authority (ESMA) Directive 2004/39/EC."
    )]
    InvestmentFirm = CorporateSectorIdentifierCode.InvestmentFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Institution for occupational retirement provision within the meaning of Article 6(a) of European Securities and Markets Authority (ESMA) Directive 2003/41/EC.
    /// Encoded/decoded by serializers as &quot;O&quot;.
    /// </summary>
    [EnumMember(Value = "O")]
    [IsoId("_ihSMsVBdEeOenoknK_-H2g")]
    [Description(
        @"Institution for occupational retirement provision within the meaning of Article 6(a) of European Securities and Markets Authority (ESMA) Directive 2003/41/EC."
    )]
    OccupationalRetirementProvision = CorporateSectorIdentifierCode.OccupationalRetirementProvision, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reinsurance undertaking authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2005/68/EC.
    /// Encoded/decoded by serializers as &quot;R&quot;.
    /// </summary>
    [EnumMember(Value = "R")]
    [IsoId("_inGg0VBdEeOenoknK_-H2g")]
    [Description(
        @"Reinsurance undertaking authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2005/68/EC."
    )]
    Reinsurance = CorporateSectorIdentifierCode.Reinsurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertakings for Collective Investment in Transferable Securities (UCITS) and its management company, authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2009/95/EC.
    /// Encoded/decoded by serializers as &quot;U&quot;.
    /// </summary>
    [EnumMember(Value = "U")]
    [IsoId("_itD-4VBdEeOenoknK_-H2g")]
    [Description(
        @"Undertakings for Collective Investment in Transferable Securities (UCITS) and its management company, authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2009/95/EC."
    )]
    UCITS = CorporateSectorIdentifierCode.UCITS, // same ordinal as derivation source for type conversions
}
