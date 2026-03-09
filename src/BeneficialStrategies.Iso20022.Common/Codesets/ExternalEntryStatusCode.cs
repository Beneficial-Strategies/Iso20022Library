// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an entry on the books of the account servicer, as published in an external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w3XE8a6IEeexrtTFgmVD3Q")]
[Description(@"Specifies the status of an entry on the books of the account servicer, as published in an external code set.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalEntryStatus1Code))]
public enum ExternalEntryStatusCode
{
    /// <summary>
    /// Booked means that the transfer of money has been completed between account servicer and account owner.|Usage: Status Booked does not necessarily imply finality of money as this depends on other factors such as the payment system used, the completion of the end-to-end transaction and the terms agreed between account servicer and owner.|Status Booked is the only status that can be reversed.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_ubgTQPRYEeuLhpyIdtJzwg")]
    [Description(@"Booked means that the transfer of money has been completed between account servicer and account owner.|Usage: Status Booked does not necessarily imply finality of money as this depends on other factors such as the payment system used, the completion of the end-to-end transaction and the terms agreed between account servicer and owner.|Status Booked is the only status that can be reversed.")]
    Booked,
    
    /// <summary>
    /// Entry is on the books of the account servicer and value will be applied to the account owner at a future date and time.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_ubgTQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Entry is on the books of the account servicer and value will be applied to the account owner at a future date and time.")]
    Future,
    
    /// <summary>
    /// Entry is only provided for information, and no booking on the account owner&apos;s account in the account servicer&apos;s ledger has been performed.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_ubgTRvRYEeuLhpyIdtJzwg")]
    [Description(@"Entry is only provided for information, and no booking on the account owner's account in the account servicer's ledger has been performed.")]
    Information,
    
    /// <summary>
    /// Booking on the account owner&apos;s account in the account servicer&apos;s ledger has not been completed.|Usage: this can be used for expected items, or for items for which some conditions still need to be fulfilled before they can be booked. If booking takes place, the entry will be included with status Booked in subsequent account report or statement. Status Pending cannot be reversed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_ubgTSfRYEeuLhpyIdtJzwg")]
    [Description(@"Booking on the account owner's account in the account servicer's ledger has not been completed.|Usage: this can be used for expected items, or for items for which some conditions still need to be fulfilled before they can be booked. If booking takes place, the entry will be included with status Booked in subsequent account report or statement. Status Pending cannot be reversed.")]
    Pending,
    
}
