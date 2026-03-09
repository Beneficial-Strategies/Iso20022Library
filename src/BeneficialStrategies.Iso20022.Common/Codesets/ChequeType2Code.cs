// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of cheque.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a-xYudp-Ed-ak6NoX_4Aeg_1427080756")]
[Description(@"Specifies the type of cheque.")]
[DerivedFrom(typeof(ChequeTypeCode))]
public enum ChequeType2Code
{
    /// <summary>
    /// Cheque drawn on the account of the debtor, and debited on the debtor&apos;s account when the cheque is cashed. Synonym is &apos;corporate cheque&apos;.
    /// Encoded/decoded by serializers as &quot;CCHQ&quot;.
    /// </summary>
    [EnumMember(Value = "CCHQ")]
    [IsoId("_a-7JsNp-Ed-ak6NoX_4Aeg_1485265041")]
    [Description(@"Cheque drawn on the account of the debtor, and debited on the debtor's account when the cheque is cashed. Synonym is 'corporate cheque'.")]
    CustomerCheque = ChequeTypeCode.CustomerCheque, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cheque drawn on the account of the debtor, and debited on the debtor&apos;s account when the cheque is cashed. The financial institution prints and certifies the cheque, guaranteeing the payment.
    /// Encoded/decoded by serializers as &quot;CCCH&quot;.
    /// </summary>
    [EnumMember(Value = "CCCH")]
    [IsoId("_a-7Jsdp-Ed-ak6NoX_4Aeg_1485265119")]
    [Description(@"Cheque drawn on the account of the debtor, and debited on the debtor's account when the cheque is cashed. The financial institution prints and certifies the cheque, guaranteeing the payment.")]
    CertifiedCustomerCheque = ChequeTypeCode.CertifiedCustomerCheque, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cheque drawn on the account of the debtor&apos;s financial institution, which is debited on the debtor&apos;s account when the cheque is issued.These cheques are printed by the debtor&apos;s financial institution and payment is guaranteed by the financial institution. Synonym is &apos;cashier&apos;s cheque&apos;.
    /// Encoded/decoded by serializers as &quot;BCHQ&quot;.
    /// </summary>
    [EnumMember(Value = "BCHQ")]
    [IsoId("_a-7Jstp-Ed-ak6NoX_4Aeg_1485265197")]
    [Description(@"Cheque drawn on the account of the debtor's financial institution, which is debited on the debtor's account when the cheque is issued.These cheques are printed by the debtor's financial institution and payment is guaranteed by the financial institution. Synonym is 'cashier's cheque'.")]
    BankCheque = ChequeTypeCode.BankCheque, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A guaranteed bank cheque with a future value date (do not pay before], which in commercial terms is a &apos;negotiatable instrument&apos;: the beneficiary can receive early payment from any bank under subtraction of a discount. The ordering customer&apos;s account is debited on value date.
    /// Encoded/decoded by serializers as &quot;DRFT&quot;.
    /// </summary>
    [EnumMember(Value = "DRFT")]
    [IsoId("_a-7Js9p-Ed-ak6NoX_4Aeg_1485265523")]
    [Description(@"A guaranteed bank cheque with a future value date (do not pay before], which in commercial terms is a 'negotiatable instrument': the beneficiary can receive early payment from any bank under subtraction of a discount. The ordering customer's account is debited on value date.")]
    Draft = ChequeTypeCode.Draft, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An instrument with a future value date (do not pay before], which in commercial terms is a &apos;negotiatable instrument&apos;: the beneficiary can receive early payment from any bank under subtraction of a discount. The ordering customer&apos;s account is debited on value date.
    /// Encoded/decoded by serializers as &quot;ELDR&quot;.
    /// </summary>
    [EnumMember(Value = "ELDR")]
    [IsoId("_a-7JtNp-Ed-ak6NoX_4Aeg_-1349960623")]
    [Description(@"An instrument with a future value date (do not pay before], which in commercial terms is a 'negotiatable instrument': the beneficiary can receive early payment from any bank under subtraction of a discount. The ordering customer's account is debited on value date.")]
    ElectronicDraft = ChequeTypeCode.ElectronicDraft, // same ordinal as derivation source for type conversions
    
}
