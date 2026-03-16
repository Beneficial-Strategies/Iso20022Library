// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an entry.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ahkfVNp-Ed-ak6NoX_4Aeg_-1206685365")]
[Description(@"Specifies the status of an entry.")]
[DerivedFrom(typeof(EntryStatusCode))]
public enum EntryStatus3Code
{
    /// <summary>
    /// Booked means that the transfer of money has been completed between account servicer and account owner||Usage: |Status Booked does not necessarily imply finality of money as this depends on other factors such as the payment system used, the completion of the end-to-end transaction and the terms agreed between account servicer and owner.|Status Booked is the only status that can be reversed.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_ahkfVdp-Ed-ak6NoX_4Aeg_-1206685122")]
    [Description(
        @"Booked means that the transfer of money has been completed between account servicer and account owner||Usage: |Status Booked does not necessarily imply finality of money as this depends on other factors such as the payment system used, the completion of the end-to-end transaction and the terms agreed between account servicer and owner.|Status Booked is the only status that can be reversed."
    )]
    Booked = EntryStatusCode.Booked, // same ordinal as derivation source for type conversions
}
