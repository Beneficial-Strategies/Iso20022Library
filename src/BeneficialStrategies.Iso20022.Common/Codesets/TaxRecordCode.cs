// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax details.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YiKMVtp-Ed-ak6NoX_4Aeg_-1942037713")]
[Description(@"Specifies the type of tax details.")]
[Derivations(typeof(TaxRecord1Code))]
public enum TaxRecordCode
{
    /// <summary>
    /// Tax record is related to the withholding tax.
    /// Encoded/decoded by serializers as &quot;WHTX&quot;.
    /// </summary>
    [EnumMember(Value = "WHTX")]
    [IsoId("_YiKMV9p-Ed-ak6NoX_4Aeg_-1037908174")]
    [Description(@"Tax record is related to the withholding tax.")]
    WithholdingTax,
    
    /// <summary>
    /// Tax record is related to the value added tax.
    /// Encoded/decoded by serializers as &quot;VATX&quot;.
    /// </summary>
    [EnumMember(Value = "VATX")]
    [IsoId("_YiKMWNp-Ed-ak6NoX_4Aeg_-651879399")]
    [Description(@"Tax record is related to the value added tax.")]
    ValueAddedTax,
    
    /// <summary>
    /// Tax record is related to the income payment details.
    /// Encoded/decoded by serializers as &quot;INCP&quot;.
    /// </summary>
    [EnumMember(Value = "INCP")]
    [IsoId("_YiKMWdp-Ed-ak6NoX_4Aeg_-633408857")]
    [Description(@"Tax record is related to the income payment details.")]
    IncomePaymentDetails,
    
    /// <summary>
    /// Tax record is related to the total amount for income payments.
    /// Encoded/decoded by serializers as &quot;TLAI&quot;.
    /// </summary>
    [EnumMember(Value = "TLAI")]
    [IsoId("_YiT9UNp-Ed-ak6NoX_4Aeg_-593696598")]
    [Description(@"Tax record is related to the total amount for income payments.")]
    TotalAmountForIncomePayments,
    
    /// <summary>
    /// Tax record is related to the money payments details.
    /// Encoded/decoded by serializers as &quot;MONP&quot;.
    /// </summary>
    [EnumMember(Value = "MONP")]
    [IsoId("_YiT9Udp-Ed-ak6NoX_4Aeg_-553984825")]
    [Description(@"Tax record is related to the money payments details.")]
    MoneyPaymentDetails,
    
    /// <summary>
    /// Tax record is related to the total amount for money payments.
    /// Encoded/decoded by serializers as &quot;TLAM&quot;.
    /// </summary>
    [EnumMember(Value = "TLAM")]
    [IsoId("_YiT9Utp-Ed-ak6NoX_4Aeg_-527203633")]
    [Description(@"Tax record is related to the total amount for money payments.")]
    TotalAmountForMoneyPayments,
    
    /// <summary>
    /// Other tax record type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_YiT9U9p-Ed-ak6NoX_4Aeg_-495801470")]
    [Description(@"Other tax record type.")]
    Other,
    
}
