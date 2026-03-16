// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the amount, as published in an external document amount type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IXo2MDH1Ee6BxvG014AZzQ")]
[Description(
    @"Specifies the nature, or use, of the amount, as published in an external document amount type code set."
)]
[Derivations(typeof(ExternalDocumentAmountType1Code))]
public enum ExternalDocumentAmountTypeCode
{
    /// <summary>
    /// Addition discount based on third-party agreed business promotional activity, for example, in-store, seasonal, promotional.
    /// Encoded/decoded by serializers as &quot;APDS&quot;.
    /// </summary>
    [EnumMember(Value = "APDS")]
    [IsoId("")]
    [Description(
        @"Addition discount based on third-party agreed business promotional activity, for example, in-store, seasonal, promotional."
    )]
    AdditionalPromotionalDiscount,

    /// <summary>
    /// Amount is new charges, for example new charges on a credit card.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("")]
    [Description(@"Amount is new charges, for example new charges on a credit card.")]
    NewCharges,

    /// <summary>
    /// Tax accessed by city jurisdictions within a country.
    /// Encoded/decoded by serializers as &quot;CITY&quot;.
    /// </summary>
    [EnumMember(Value = "CITY")]
    [IsoId("")]
    [Description(@"Tax accessed by city jurisdictions within a country.")]
    CityTax,

    /// <summary>
    /// Tax accessed by county jurisdictions within a country.
    /// Encoded/decoded by serializers as &quot;CNTY&quot;.
    /// </summary>
    [EnumMember(Value = "CNTY")]
    [IsoId("")]
    [Description(@"Tax accessed by county jurisdictions within a country.")]
    CountyTax,

    /// <summary>
    /// Amount is a credit note.
    /// Encoded/decoded by serializers as &quot;CREN&quot;.
    /// </summary>
    [EnumMember(Value = "CREN")]
    [IsoId("")]
    [Description(@"Amount is a credit note.")]
    CreditNote,

    /// <summary>
    /// Amount is available credit.
    /// Encoded/decoded by serializers as &quot;CRTL&quot;.
    /// </summary>
    [EnumMember(Value = "CRTL")]
    [IsoId("")]
    [Description(@"Amount is available credit.")]
    AvailableCredit,

    /// <summary>
    /// Amount is due payable.
    /// Encoded/decoded by serializers as &quot;DUPA&quot;.
    /// </summary>
    [EnumMember(Value = "DUPA")]
    [IsoId("")]
    [Description(@"Amount is due payable.")]
    DuePayable,

    /// <summary>
    /// Amount is in escrow.
    /// Encoded/decoded by serializers as &quot;ESCO&quot;.
    /// </summary>
    [EnumMember(Value = "ESCO")]
    [IsoId("")]
    [Description(@"Amount is in escrow.")]
    Escrow,

    /// <summary>
    /// Amount is fees.
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("")]
    [Description(@"Amount is fees.")]
    Fees,

    /// <summary>
    /// Amount is insurance.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("")]
    [Description(@"Amount is insurance.")]
    Insurance,

    /// <summary>
    /// Amount is interest charges, for example interest charges on a credit card.
    /// Encoded/decoded by serializers as &quot;INTC&quot;.
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("")]
    [Description(@"Amount is interest charges, for example interest charges on a credit card.")]
    InterestCharges,

    /// <summary>
    /// Amount is the interest.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("")]
    [Description(@"Amount is the interest.")]
    InterestPayment,

    /// <summary>
    /// Tax accessed by local jurisdictions within a country.
    /// Encoded/decoded by serializers as &quot;LOCL&quot;.
    /// </summary>
    [EnumMember(Value = "LOCL")]
    [IsoId("")]
    [Description(@"Tax accessed by local jurisdictions within a country.")]
    LocalTax,

    /// <summary>
    /// Amount is the minimum due.
    /// Encoded/decoded by serializers as &quot;MIDU&quot;.
    /// </summary>
    [EnumMember(Value = "MIDU")]
    [IsoId("")]
    [Description(@"Amount is the minimum due.")]
    MinimumDue,

    /// <summary>
    /// Amount is the outstanding balance.
    /// Encoded/decoded by serializers as &quot;OBAL&quot;.
    /// </summary>
    [EnumMember(Value = "OBAL")]
    [IsoId("")]
    [Description(@"Amount is the outstanding balance.")]
    OutstandingBalance,

    /// <summary>
    /// Amount is past due.
    /// Encoded/decoded by serializers as &quot;PADU&quot;.
    /// </summary>
    [EnumMember(Value = "PADU")]
    [IsoId("")]
    [Description(@"Amount is past due.")]
    PastDue,

    /// <summary>
    /// Amount is the previous balance.
    /// Encoded/decoded by serializers as &quot;PBAL&quot;.
    /// </summary>
    [EnumMember(Value = "PBAL")]
    [IsoId("")]
    [Description(@"Amount is the previous balance.")]
    PreviousBalance,

    /// <summary>
    /// Amount is the outstanding principal.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("")]
    [Description(@"Amount is the outstanding principal.")]
    OutstandingPrincipal,

    /// <summary>
    /// Tax accessed by province jurisdictions within a country.
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("")]
    [Description(@"Tax accessed by province jurisdictions within a country.")]
    ProvinceTax,

    /// <summary>
    /// Amount remitted.
    /// Encoded/decoded by serializers as &quot;REMI&quot;.
    /// </summary>
    [EnumMember(Value = "REMI")]
    [IsoId("")]
    [Description(@"Amount remitted.")]
    Remitted,

    /// <summary>
    /// Amount is the statement balance.
    /// Encoded/decoded by serializers as &quot;SBAL&quot;.
    /// </summary>
    [EnumMember(Value = "SBAL")]
    [IsoId("")]
    [Description(@"Amount is the statement balance.")]
    StatementBalance,

    /// <summary>
    /// Tax accessed by state jurisdictions within a country.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("")]
    [Description(@"Tax accessed by state jurisdictions within a country.")]
    StateTax,

    /// <summary>
    /// Discount based on volume purchased.
    /// Encoded/decoded by serializers as &quot;STDS&quot;.
    /// </summary>
    [EnumMember(Value = "STDS")]
    [IsoId("")]
    [Description(@"Discount based on volume purchased.")]
    StandingDiscount,

    /// <summary>
    /// Amount is tax.
    /// Encoded/decoded by serializers as &quot;TAXS&quot;.
    /// </summary>
    [EnumMember(Value = "TAXS")]
    [IsoId("")]
    [Description(@"Amount is tax.")]
    Tax,

    /// <summary>
    /// Discount based on terms negotiated for payment within a specified time period.
    /// Encoded/decoded by serializers as &quot;TMDS&quot;.
    /// </summary>
    [EnumMember(Value = "TMDS")]
    [IsoId("")]
    [Description(@"Discount based on terms negotiated for payment within a specified time period.")]
    TermsDiscount,

    /// <summary>
    /// Amount is the total.
    /// Encoded/decoded by serializers as &quot;TOTA&quot;.
    /// </summary>
    [EnumMember(Value = "TOTA")]
    [IsoId("")]
    [Description(@"Amount is the total.")]
    TotalPayment,
}
