// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZJeuNp-Ed-ak6NoX_4Aeg_-1692318334")]
[Description(@"Specifies the type of rate.")]
[DerivedFrom(typeof(RateTypeCode))]
public enum RateType2Code
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// Encoded/decoded by serializers as &quot;ATAX&quot;.
    /// </summary>
    [EnumMember(Value = "ATAX")]
    [IsoId("_ZZTPsNp-Ed-ak6NoX_4Aeg_-1692318332")]
    [Description(@"Rate used for additional tax that cannot be categorised.")]
    AdditionalTax = RateTypeCode.AdditionalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_ZZTPsdp-Ed-ak6NoX_4Aeg_-1692318331")]
    [Description(@"Rate used to calculate the amount of the charges/fees that cannot be categorised.")]
    Charges = RateTypeCode.Charges, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate used to calculate the cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// Encoded/decoded by serializers as &quot;CINL&quot;.
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_ZZTPstp-Ed-ak6NoX_4Aeg_-1692318303")]
    [Description(@"Rate used to calculate the cash disbursement in lieu of a fractional quantity of, for example, equity.")]
    CashInLieuOfSecurities = RateTypeCode.CashInLieuOfSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash dividend per equity before deductions or allowances have been made.
    /// Encoded/decoded by serializers as &quot;GRSS&quot;.
    /// </summary>
    [EnumMember(Value = "GRSS")]
    [IsoId("_ZZTPs9p-Ed-ak6NoX_4Aeg_-1692318302")]
    [Description(@"Cash dividend per equity before deductions or allowances have been made.")]
    Gross = RateTypeCode.Gross, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example, consent fees.
    /// Encoded/decoded by serializers as &quot;INCE&quot;.
    /// </summary>
    [EnumMember(Value = "INCE")]
    [IsoId("_ZZTPtNp-Ed-ak6NoX_4Aeg_-1692318301")]
    [Description(@"Rate of the cash premium made available if the securities holder consents or participates to an event, for example, consent fees.")]
    CashIncentive = RateTypeCode.CashIncentive, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_ZZTPtdp-Ed-ak6NoX_4Aeg_-1692318025")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Net = RateTypeCode.Net, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash rate made available in an offer in order to encourage participation in the offer.
    /// Encoded/decoded by serializers as &quot;SOFE&quot;.
    /// </summary>
    [EnumMember(Value = "SOFE")]
    [IsoId("_ZZTPttp-Ed-ak6NoX_4Aeg_-1692318024")]
    [Description(@"Cash rate made available in an offer in order to encourage participation in the offer.")]
    Sollication = RateTypeCode.Sollication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument has not been stamped and/or duly signed.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_ZZTPt9p-Ed-ak6NoX_4Aeg_-1692318023")]
    [Description(@"Financial instrument has not been stamped and/or duly signed.")]
    StampDuty = RateTypeCode.StampDuty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate of stock exchange tax.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_ZZcZoNp-Ed-ak6NoX_4Aeg_-1692317994")]
    [Description(@"Rate of stock exchange tax.")]
    StockExchangeTax = RateTypeCode.StockExchangeTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been generated due to transformation following a corporate action.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZZcZodp-Ed-ak6NoX_4Aeg_-1692317993")]
    [Description(@"Transaction has been generated due to transformation following a corporate action.")]
    TransferTax = RateTypeCode.TransferTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate used to calculate the amount of transaction tax.
    /// Encoded/decoded by serializers as &quot;TRAX&quot;.
    /// </summary>
    [EnumMember(Value = "TRAX")]
    [IsoId("_ZZcZotp-Ed-ak6NoX_4Aeg_-1692317964")]
    [Description(@"Rate used to calculate the amount of transaction tax.")]
    TransactionTax = RateTypeCode.TransactionTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate relating to the underlying security for which tax is deferred.
    /// Encoded/decoded by serializers as &quot;TXDF&quot;.
    /// </summary>
    [EnumMember(Value = "TXDF")]
    [IsoId("_ZZcZo9p-Ed-ak6NoX_4Aeg_-1692317963")]
    [Description(@"Rate relating to the underlying security for which tax is deferred.")]
    TaxDeferred = RateTypeCode.TaxDeferred, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate relating to the underlying security which is not taxable.
    /// Encoded/decoded by serializers as &quot;TXFR&quot;.
    /// </summary>
    [EnumMember(Value = "TXFR")]
    [IsoId("_ZZcZpNp-Ed-ak6NoX_4Aeg_-1692317962")]
    [Description(@"Rate relating to the underlying security which is not taxable.")]
    TaxFeeAmount = RateTypeCode.TaxFeeAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITF&quot;.
    /// </summary>
    [EnumMember(Value = "WITF")]
    [IsoId("_ZZcZpdp-Ed-ak6NoX_4Aeg_-1692317933")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfForeignTax = RateTypeCode.WithholdingOfForeignTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITL&quot;.
    /// </summary>
    [EnumMember(Value = "WITL")]
    [IsoId("_ZZcZptp-Ed-ak6NoX_4Aeg_-1692317932")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfLocalTax = RateTypeCode.WithholdingOfLocalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a tax refund from the authorities on the associated corporate action event.
    /// Encoded/decoded by serializers as &quot;TAXR&quot;.
    /// </summary>
    [EnumMember(Value = "TAXR")]
    [IsoId("_ZZcZp9p-Ed-ak6NoX_4Aeg_-1692317902")]
    [Description(@"Relates to a tax refund from the authorities on the associated corporate action event.")]
    WithholdingTax = RateTypeCode.WithholdingTax, // same ordinal as derivation source for type conversions
    
}
