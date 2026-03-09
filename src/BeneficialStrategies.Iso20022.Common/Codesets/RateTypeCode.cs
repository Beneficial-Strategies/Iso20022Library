// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Any and all rate is sought.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZvUldp-Ed-ak6NoX_4Aeg_233339087")]
[Description(@"Any and all rate is sought.")]
[Derivations(typeof(RateValueType6Code),typeof(RateValueType7Code),typeof(RateType10Code),typeof(RateType13Code),typeof(RateType8Code),typeof(RateType9Code),typeof(RateType3Code),typeof(RateValueType2Code),typeof(RateType12Code),typeof(RateType5Code),typeof(RateType2Code))]
public enum RateTypeCode
{
    /// <summary>
    /// Rate is fixed.
    /// Encoded/decoded by serializers as &quot;FIXE&quot;.
    /// </summary>
    [EnumMember(Value = "FIXE")]
    [IsoId("_ZZvUltp-Ed-ak6NoX_4Aeg_-453104163")]
    [Description(@"Rate is fixed.")]
    Fixed,
    
    /// <summary>
    /// No specific repurchase rate applies to the transaction Repo, only a forfeit.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_ZZvUl9p-Ed-ak6NoX_4Aeg_-442020053")]
    [Description(@"No specific repurchase rate applies to the transaction Repo, only a forfeit.")]
    Forfeit,
    
    /// <summary>
    /// Rate is variable.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_ZZvUmNp-Ed-ak6NoX_4Aeg_-430014715")]
    [Description(@"Rate is variable.")]
    Variable,
    
    /// <summary>
    /// Rate has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_ZZ5FkNp-Ed-ak6NoX_4Aeg_423683220")]
    [Description(@"Rate has not been established.")]
    Open,
    
    /// <summary>
    /// Rate is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZZ5Fkdp-Ed-ak6NoX_4Aeg_423683251")]
    [Description(@"Rate is unknown by the sender or has not been established.")]
    Unknown,
    
    /// <summary>
    /// Rate will not be paid.
    /// Encoded/decoded by serializers as &quot;NILP&quot;.
    /// </summary>
    [EnumMember(Value = "NILP")]
    [IsoId("_ZZ5Fktp-Ed-ak6NoX_4Aeg_423683312")]
    [Description(@"Rate will not be paid.")]
    NilPayment,
    
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// Encoded/decoded by serializers as &quot;ATAX&quot;.
    /// </summary>
    [EnumMember(Value = "ATAX")]
    [IsoId("_ZZ5Fk9p-Ed-ak6NoX_4Aeg_423683373")]
    [Description(@"Rate used for additional tax that cannot be categorised.")]
    AdditionalTax,
    
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_ZZ5FlNp-Ed-ak6NoX_4Aeg_423683404")]
    [Description(@"Rate used to calculate the amount of the charges/fees that cannot be categorised.")]
    Charges,
    
    /// <summary>
    /// Rate used to calculate the cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// Encoded/decoded by serializers as &quot;CINL&quot;.
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_ZZ5Fldp-Ed-ak6NoX_4Aeg_423683465")]
    [Description(@"Rate used to calculate the cash disbursement in lieu of a fractional quantity of, for example, equity.")]
    CashInLieuOfSecurities,
    
    /// <summary>
    /// Cash dividend per equity before deductions or allowances have been made.
    /// Encoded/decoded by serializers as &quot;GRSS&quot;.
    /// </summary>
    [EnumMember(Value = "GRSS")]
    [IsoId("_ZZ5Fltp-Ed-ak6NoX_4Aeg_423683743")]
    [Description(@"Cash dividend per equity before deductions or allowances have been made.")]
    Gross,
    
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example, consent fees.
    /// Encoded/decoded by serializers as &quot;INCE&quot;.
    /// </summary>
    [EnumMember(Value = "INCE")]
    [IsoId("_ZZ5Fl9p-Ed-ak6NoX_4Aeg_423683774")]
    [Description(@"Rate of the cash premium made available if the securities holder consents or participates to an event, for example, consent fees.")]
    CashIncentive,
    
    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_ZZ5FmNp-Ed-ak6NoX_4Aeg_423683835")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Net,
    
    /// <summary>
    /// Cash rate made available in an offer in order to encourage participation in the offer.
    /// Encoded/decoded by serializers as &quot;SOFE&quot;.
    /// </summary>
    [EnumMember(Value = "SOFE")]
    [IsoId("_ZZ5Fmdp-Ed-ak6NoX_4Aeg_423683866")]
    [Description(@"Cash rate made available in an offer in order to encourage participation in the offer.")]
    Sollication,
    
    /// <summary>
    /// Financial instrument has not been stamped and/or duly signed.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_ZZ5Fmtp-Ed-ak6NoX_4Aeg_423683897")]
    [Description(@"Financial instrument has not been stamped and/or duly signed.")]
    StampDuty,
    
    /// <summary>
    /// Rate of stock exchange tax.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_ZaC2kNp-Ed-ak6NoX_4Aeg_423684206")]
    [Description(@"Rate of stock exchange tax.")]
    StockExchangeTax,
    
    /// <summary>
    /// Relates to a tax refund from the authorities on the associated corporate action event.
    /// Encoded/decoded by serializers as &quot;TAXR&quot;.
    /// </summary>
    [EnumMember(Value = "TAXR")]
    [IsoId("_ZaC2kdp-Ed-ak6NoX_4Aeg_423684236")]
    [Description(@"Relates to a tax refund from the authorities on the associated corporate action event.")]
    WithholdingTax,
    
    /// <summary>
    /// Transaction has been generated due to transformation following a corporate action.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZaC2ktp-Ed-ak6NoX_4Aeg_423684298")]
    [Description(@"Transaction has been generated due to transformation following a corporate action.")]
    TransferTax,
    
    /// <summary>
    /// Rate used to calculate the amount of transaction tax.
    /// Encoded/decoded by serializers as &quot;TRAX&quot;.
    /// </summary>
    [EnumMember(Value = "TRAX")]
    [IsoId("_ZaC2k9p-Ed-ak6NoX_4Aeg_423684359")]
    [Description(@"Rate used to calculate the amount of transaction tax.")]
    TransactionTax,
    
    /// <summary>
    /// Rate relating to the underlying security for which tax is deferred.
    /// Encoded/decoded by serializers as &quot;TXDF&quot;.
    /// </summary>
    [EnumMember(Value = "TXDF")]
    [IsoId("_ZaC2lNp-Ed-ak6NoX_4Aeg_423684390")]
    [Description(@"Rate relating to the underlying security for which tax is deferred.")]
    TaxDeferred,
    
    /// <summary>
    /// Rate relating to the underlying security which is not taxable.
    /// Encoded/decoded by serializers as &quot;TXFR&quot;.
    /// </summary>
    [EnumMember(Value = "TXFR")]
    [IsoId("_ZaC2ldp-Ed-ak6NoX_4Aeg_423684451")]
    [Description(@"Rate relating to the underlying security which is not taxable.")]
    TaxFeeAmount,
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITF&quot;.
    /// </summary>
    [EnumMember(Value = "WITF")]
    [IsoId("_ZaC2ltp-Ed-ak6NoX_4Aeg_423684782")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfForeignTax,
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITL&quot;.
    /// </summary>
    [EnumMember(Value = "WITL")]
    [IsoId("_ZaC2l9p-Ed-ak6NoX_4Aeg_424604846")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfLocalTax,
    
    /// <summary>
    /// Imputed tax.
    /// Encoded/decoded by serializers as &quot;IMPU&quot;.
    /// </summary>
    [EnumMember(Value = "IMPU")]
    [IsoId("_ZaC2mNp-Ed-ak6NoX_4Aeg_424604907")]
    [Description(@"Imputed tax.")]
    Imputed,
    
    /// <summary>
    /// Rate is a precompte.
    /// Encoded/decoded by serializers as &quot;PREC&quot;.
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_ZaC2mdp-Ed-ak6NoX_4Aeg_424604969")]
    [Description(@"Rate is a precompte.")]
    Precompte,
    
    /// <summary>
    /// Rate is a one tier tax.
    /// Encoded/decoded by serializers as &quot;TIER&quot;.
    /// </summary>
    [EnumMember(Value = "TIER")]
    [IsoId("_ZaMAgNp-Ed-ak6NoX_4Aeg_424605030")]
    [Description(@"Rate is a one tier tax.")]
    OneTierTax,
    
    /// <summary>
    /// Interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).
    /// Encoded/decoded by serializers as &quot;LIDT&quot;.
    /// </summary>
    [EnumMember(Value = "LIDT")]
    [IsoId("_ZaMAgdp-Ed-ak6NoX_4Aeg_424605339")]
    [Description(@"Interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).")]
    LocalTax,
    
    /// <summary>
    /// Rate of the scheduled payment.
    /// Encoded/decoded by serializers as &quot;SCHD&quot;.
    /// </summary>
    [EnumMember(Value = "SCHD")]
    [IsoId("_ZaMAgtp-Ed-ak6NoX_4Aeg_424605400")]
    [Description(@"Rate of the scheduled payment.")]
    Scheduled,
    
    /// <summary>
    /// Rate of the unscheduled payment.
    /// Encoded/decoded by serializers as &quot;USCD&quot;.
    /// </summary>
    [EnumMember(Value = "USCD")]
    [IsoId("_ZaMAg9p-Ed-ak6NoX_4Aeg_424605461")]
    [Description(@"Rate of the unscheduled payment.")]
    Unscheduled,
    
    /// <summary>
    /// Any and all rate is sought.
    /// Encoded/decoded by serializers as &quot;ANYA&quot;.
    /// </summary>
    [EnumMember(Value = "ANYA")]
    [IsoId("_ZaMAhNp-Ed-ak6NoX_4Aeg_424605771")]
    [Description(@"Any and all rate is sought.")]
    AnyAndAll,
    
}
