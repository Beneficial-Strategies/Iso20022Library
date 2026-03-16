// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of cheque.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a-7JuNp-Ed-ak6NoX_4Aeg_815766643")]
[Description(@"Specifies the type of cheque.")]
[Derivations(typeof(ChequeType2Code), typeof(ChequeType3Code))]
public enum ChequeTypeCode
{
    /// <summary>
    /// Cheque that must be paid into an account and not cashed over the counter. There are two parallel lines across the face of a crossed cheque.
    /// Encoded/decoded by serializers as &quot;CRCQ&quot;.
    /// </summary>
    [EnumMember(Value = "CRCQ")]
    [IsoId("_a_EToNp-Ed-ak6NoX_4Aeg_851782112")]
    [Description(
        @"Cheque that must be paid into an account and not cashed over the counter. There are two parallel lines across the face of a crossed cheque."
    )]
    CrossedCheque,

    /// <summary>
    /// Cheque that may only be cashed at the bank of origin.
    /// Encoded/decoded by serializers as &quot;OPCQ&quot;.
    /// </summary>
    [EnumMember(Value = "OPCQ")]
    [IsoId("_a_ETodp-Ed-ak6NoX_4Aeg_851782395")]
    [Description(@"Cheque that may only be cashed at the bank of origin.")]
    OpenCheque,

    /// <summary>
    /// Cheque made payable to a named recipient &apos;or order&apos;. The payee can either deposit the cheque in an account or endorse it to a third party.
    /// Encoded/decoded by serializers as &quot;ORCQ&quot;.
    /// </summary>
    [EnumMember(Value = "ORCQ")]
    [IsoId("_a_ETotp-Ed-ak6NoX_4Aeg_851782413")]
    [Description(
        @"Cheque made payable to a named recipient 'or order'. The payee can either deposit the cheque in an account or endorse it to a third party."
    )]
    OrderCheque,

    /// <summary>
    /// An instruction from a bank to its correspondent bank to pay the creditor a stated sum upon the presentation of a means of identification.
    /// Encoded/decoded by serializers as &quot;CLCQ&quot;.
    /// </summary>
    [EnumMember(Value = "CLCQ")]
    [IsoId("_a_ETo9p-Ed-ak6NoX_4Aeg_851782438")]
    [Description(
        @"An instruction from a bank to its correspondent bank to pay the creditor a stated sum upon the presentation of a means of identification."
    )]
    CircularCheque,

    /// <summary>
    /// Cheque drawn by a bank on itself or its agent. A person who owes money to another buys the draft from a bank for cash and hands it to the creditor who need have no fear that it might be dishonoured. A bank draft is also called a banker&apos;s cheque, banker&apos;s draft, bank check, or treasurer&apos;s check.
    /// Encoded/decoded by serializers as &quot;BKDF&quot;.
    /// </summary>
    [EnumMember(Value = "BKDF")]
    [IsoId("_a_ETpNp-Ed-ak6NoX_4Aeg_851782498")]
    [Description(
        @"Cheque drawn by a bank on itself or its agent. A person who owes money to another buys the draft from a bank for cash and hands it to the creditor who need have no fear that it might be dishonoured. A bank draft is also called a banker's cheque, banker's draft, bank check, or treasurer's check."
    )]
    BankDraft,

    /// <summary>
    /// Cheque drawn on the account of the debtor, and debited on the debtor&apos;s account when the cheque is cashed. Synonym is &apos;corporate cheque&apos;.
    /// Encoded/decoded by serializers as &quot;CCHQ&quot;.
    /// </summary>
    [EnumMember(Value = "CCHQ")]
    [IsoId("_a_ETpdp-Ed-ak6NoX_4Aeg_-128394796")]
    [Description(
        @"Cheque drawn on the account of the debtor, and debited on the debtor's account when the cheque is cashed. Synonym is 'corporate cheque'."
    )]
    CustomerCheque,

    /// <summary>
    /// Cheque drawn on the account of the debtor, and debited on the debtor&apos;s account when the cheque is cashed. The financial institution prints and certifies the cheque, guaranteeing the payment.
    /// Encoded/decoded by serializers as &quot;CCCH&quot;.
    /// </summary>
    [EnumMember(Value = "CCCH")]
    [IsoId("_a_ETptp-Ed-ak6NoX_4Aeg_-115464556")]
    [Description(
        @"Cheque drawn on the account of the debtor, and debited on the debtor's account when the cheque is cashed. The financial institution prints and certifies the cheque, guaranteeing the payment."
    )]
    CertifiedCustomerCheque,

    /// <summary>
    /// Cheque drawn on the account of the debtor&apos;s financial institution, which is debited on the debtor&apos;s account when the cheque is issued.These cheques are printed by the debtor&apos;s financial institution and payment is guaranteed by the financial institution. Synonym is &apos;cashier&apos;s cheque&apos;.
    /// Encoded/decoded by serializers as &quot;BCHQ&quot;.
    /// </summary>
    [EnumMember(Value = "BCHQ")]
    [IsoId("_a_ETp9p-Ed-ak6NoX_4Aeg_-110847322")]
    [Description(
        @"Cheque drawn on the account of the debtor's financial institution, which is debited on the debtor's account when the cheque is issued.These cheques are printed by the debtor's financial institution and payment is guaranteed by the financial institution. Synonym is 'cashier's cheque'."
    )]
    BankCheque,

    /// <summary>
    /// A guaranteed bank cheque with a future value date (do not pay before], which in commercial terms is a &apos;negotiatable instrument&apos;: the beneficiary can receive early payment from any bank under subtraction of a discount. The ordering customer&apos;s account is debited on value date.
    /// Encoded/decoded by serializers as &quot;DRFT&quot;.
    /// </summary>
    [EnumMember(Value = "DRFT")]
    [IsoId("_a_ETqNp-Ed-ak6NoX_4Aeg_-95146540")]
    [Description(
        @"A guaranteed bank cheque with a future value date (do not pay before], which in commercial terms is a 'negotiatable instrument': the beneficiary can receive early payment from any bank under subtraction of a discount. The ordering customer's account is debited on value date."
    )]
    Draft,

    /// <summary>
    /// An instrument with a future value date (do not pay before], which in commercial terms is a &apos;negotiatable instrument&apos;: the beneficiary can receive early payment from any bank under subtraction of a discount. The ordering customer&apos;s account is debited on value date.
    /// Encoded/decoded by serializers as &quot;ELDR&quot;.
    /// </summary>
    [EnumMember(Value = "ELDR")]
    [IsoId("_a_ETqdp-Ed-ak6NoX_4Aeg_-82218557")]
    [Description(
        @"An instrument with a future value date (do not pay before], which in commercial terms is a 'negotiatable instrument': the beneficiary can receive early payment from any bank under subtraction of a discount. The ordering customer's account is debited on value date."
    )]
    ElectronicDraft,

    /// <summary>
    /// Cheque intiated or completed through an online service.
    /// Encoded/decoded by serializers as &quot;OCHQ&quot;.
    /// </summary>
    [EnumMember(Value = "OCHQ")]
    [IsoId("_xFIQQGYMEeOTFYEr0vLhkw")]
    [Description(@"Cheque intiated or completed through an online service.")]
    OnlineCheque,
}
