// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transfer method that will be used to transfer the cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z0uAYNp-Ed-ak6NoX_4Aeg_2143732969")]
[Description(@"Specifies the transfer method that will be used to transfer the cash.")]
[Derivations(
    typeof(PaymentMethod2Code),
    typeof(PaymentMethod6Code),
    typeof(PaymentMethod3Code),
    typeof(PaymentMethod5Code),
    typeof(PaymentMethod7Code),
    typeof(PaymentMethod4Code)
)]
public enum PaymentMethodCode
{
    /// <summary>
    /// Written order to a bank to pay a certain amount of money from one person to another person.
    /// Encoded/decoded by serializers as &quot;CHK&quot;.
    /// </summary>
    [EnumMember(Value = "CHK")]
    [IsoId("_Z0uAYdp-Ed-ak6NoX_4Aeg_2143732977")]
    [Description(
        @"Written order to a bank to pay a certain amount of money from one person to another person."
    )]
    Cheque,

    /// <summary>
    /// Transfer of an amount of money in the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;TRF&quot;.
    /// </summary>
    [EnumMember(Value = "TRF")]
    [IsoId("_Z0uAYtp-Ed-ak6NoX_4Aeg_2143732978")]
    [Description(@"Transfer of an amount of money in the books of the account servicer.")]
    CreditTransfer,

    /// <summary>
    /// Collection of an amount of money from the debtor&apos;s bank account by the creditor. The amount of money and dates of collections may vary.
    /// Encoded/decoded by serializers as &quot;DD&quot;.
    /// </summary>
    [EnumMember(Value = "DD")]
    [IsoId("_Z0uAY9p-Ed-ak6NoX_4Aeg_480922145")]
    [Description(
        @"Collection of an amount of money from the debtor's bank account by the creditor. The amount of money and dates of collections may vary."
    )]
    DirectDebit,

    /// <summary>
    /// Transfer of an amount of money in the books of the account servicer. An advice should be sent back to the account owner.
    /// Encoded/decoded by serializers as &quot;TRA&quot;.
    /// </summary>
    [EnumMember(Value = "TRA")]
    [IsoId("_Z0uAZNp-Ed-ak6NoX_4Aeg_1896180544")]
    [Description(
        @"Transfer of an amount of money in the books of the account servicer. An advice should be sent back to the account owner."
    )]
    TransferAdvice,

    /// <summary>
    /// Direct method.
    /// Encoded/decoded by serializers as &quot;DIRE&quot;.
    /// </summary>
    [EnumMember(Value = "DIRE")]
    [IsoId("_Z0uAZdp-Ed-ak6NoX_4Aeg_-545130742")]
    [Description(@"Direct method.")]
    Direct,

    /// <summary>
    /// Classical method.
    /// Encoded/decoded by serializers as &quot;CLAS&quot;.
    /// </summary>
    [EnumMember(Value = "CLAS")]
    [IsoId("_Z0uAZtp-Ed-ak6NoX_4Aeg_-545130741")]
    [Description(@"Classical method.")]
    Classical,
}
