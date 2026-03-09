// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an entry.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ahauU9p-Ed-ak6NoX_4Aeg_-773188206")]
[Description(@"Specifies the status of an entry.")]
[DerivedFrom(typeof(EntryStatusCode))]
public enum EntryStatus1Code
{
    /// <summary>
    /// Booked means that the transfer of money has been completed between account servicer and account owner||Usage: |Status Booked does not necessarily imply finality of money as this depends on other factors such as the payment system used, the completion of the end-to-end transaction and the terms agreed between account servicer and owner.|Status Booked is the only status that can be reversed.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_ahauVNp-Ed-ak6NoX_4Aeg_-773188205")]
    [Description(@"Booked means that the transfer of money has been completed between account servicer and account owner||Usage: |Status Booked does not necessarily imply finality of money as this depends on other factors such as the payment system used, the completion of the end-to-end transaction and the terms agreed between account servicer and owner.|Status Booked is the only status that can be reversed.")]
    Booked = EntryStatusCode.Booked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Booking on the account owner&apos;s account in the account servicer&apos;s ledger has not been completed.||Usage: this can be used for expected items, or for items for which some conditions still need to be fulfilled before they can be booked. If booking takes place, the entry will be included with status Booked in subsequent account report or statement. Status Pending cannot be reversed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_ahauVdp-Ed-ak6NoX_4Aeg_-773188204")]
    [Description(@"Booking on the account owner's account in the account servicer's ledger has not been completed.||Usage: this can be used for expected items, or for items for which some conditions still need to be fulfilled before they can be booked. If booking takes place, the entry will be included with status Booked in subsequent account report or statement. Status Pending cannot be reversed.")]
    Pending = EntryStatusCode.Pending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entry is on the books of the account servicer and value will be applied to the account owner at a future date and time.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_ahauVtp-Ed-ak6NoX_4Aeg_-773188203")]
    [Description(@"Entry is on the books of the account servicer and value will be applied to the account owner at a future date and time.")]
    Future = EntryStatusCode.Future, // same ordinal as derivation source for type conversions
    
}
