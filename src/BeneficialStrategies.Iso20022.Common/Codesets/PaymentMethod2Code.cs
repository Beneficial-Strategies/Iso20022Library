// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transfer method that will be used to transfer the cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z0aeYNp-Ed-ak6NoX_4Aeg_-15953636")]
[Description(@"Specifies the transfer method that will be used to transfer the cash.")]
[DerivedFrom(typeof(PaymentMethodCode))]
public enum PaymentMethod2Code
{
    /// <summary>
    /// Collection of an amount of money from the debtor&apos;s bank account by the creditor. The amount of money and dates of collections may vary.
    /// Encoded/decoded by serializers as &quot;DD&quot;.
    /// </summary>
    [EnumMember(Value = "DD")]
    [IsoId("_Z0aeYdp-Ed-ak6NoX_4Aeg_-15953576")]
    [Description(@"Collection of an amount of money from the debtor's bank account by the creditor. The amount of money and dates of collections may vary.")]
    DirectDebit = PaymentMethodCode.DirectDebit, // same ordinal as derivation source for type conversions
    
}
