// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the corporate sector of the counterparty for reporting to trade repositories.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PDxzgVBPEeOenoknK_-H2g")]
[Description(@"Identifies the corporate sector of the counterparty for reporting to trade repositories.")]
[Derivations(typeof(CorporateSectorIdentifier1Code))]
public enum CorporateSectorIdentifierCode
{
    /// <summary>
    /// Assurance undertaking authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2002/83/EC.
    /// Encoded/decoded by serializers as &quot;A&quot;.
    /// </summary>
    [EnumMember(Value = "A")]
    [IsoId("_0cxqQFBPEeOenoknK_-H2g")]
    [Description(@"Assurance undertaking authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2002/83/EC.")]
    Assurance,
    
    /// <summary>
    /// Credit Institution authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2006/48/EC.
    /// Encoded/decoded by serializers as &quot;C&quot;.
    /// </summary>
    [EnumMember(Value = "C")]
    [IsoId("_F2V-IFBQEeOenoknK_-H2g")]
    [Description(@"Credit Institution authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2006/48/EC.")]
    CreditInstitution,
    
    /// <summary>
    /// Investment firm in accordance with European Securities and Markets Authority (ESMA) Directive 2004/39/EC.
    /// Encoded/decoded by serializers as &quot;F&quot;.
    /// </summary>
    [EnumMember(Value = "F")]
    [IsoId("_S1riYFBQEeOenoknK_-H2g")]
    [Description(@"Investment firm in accordance with European Securities and Markets Authority (ESMA) Directive 2004/39/EC.")]
    InvestmentFirm,
    
    /// <summary>
    /// Insurance undertaking in accordance with European Securities and Markets Authority (ESMA) Directive 73/239/EEC.
    /// Encoded/decoded by serializers as &quot;I&quot;.
    /// </summary>
    [EnumMember(Value = "I")]
    [IsoId("_cHWiEFBQEeOenoknK_-H2g")]
    [Description(@"Insurance undertaking in accordance with European Securities and Markets Authority (ESMA) Directive 73/239/EEC.")]
    Insurance,
    
    /// <summary>
    /// Alternative investment fund managed by an Alternative Investment Fund Manager (AIFM) authorised or registered in accordance with European Securities and Markets Authority (ESMA) Directive 2011/61/EU.
    /// Encoded/decoded by serializers as &quot;L&quot;.
    /// </summary>
    [EnumMember(Value = "L")]
    [IsoId("_u6oa4FBQEeOenoknK_-H2g")]
    [Description(@"Alternative investment fund managed by an Alternative Investment Fund Manager (AIFM) authorised or registered in accordance with European Securities and Markets Authority (ESMA) Directive 2011/61/EU.")]
    AlternativeInvestmentFund,
    
    /// <summary>
    /// Institution for occupational retirement provision within the meaning of Article 6(a) of European Securities and Markets Authority (ESMA) Directive 2003/41/EC.
    /// Encoded/decoded by serializers as &quot;O&quot;.
    /// </summary>
    [EnumMember(Value = "O")]
    [IsoId("__ljgEFBQEeOenoknK_-H2g")]
    [Description(@"Institution for occupational retirement provision within the meaning of Article 6(a) of European Securities and Markets Authority (ESMA) Directive 2003/41/EC.")]
    OccupationalRetirementProvision,
    
    /// <summary>
    /// Reinsurance undertaking authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2005/68/EC.
    /// Encoded/decoded by serializers as &quot;R&quot;.
    /// </summary>
    [EnumMember(Value = "R")]
    [IsoId("_99kuQFBTEeOenoknK_-H2g")]
    [Description(@"Reinsurance undertaking authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2005/68/EC.")]
    Reinsurance,
    
    /// <summary>
    /// Undertakings for Collective Investment in Transferable Securities (UCITS) and its management company, authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2009/95/EC.
    /// Encoded/decoded by serializers as &quot;U&quot;.
    /// </summary>
    [EnumMember(Value = "U")]
    [IsoId("_INhUEFBUEeOenoknK_-H2g")]
    [Description(@"Undertakings for Collective Investment in Transferable Securities (UCITS) and its management company, authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2009/95/EC.")]
    UCITS,
    
}
