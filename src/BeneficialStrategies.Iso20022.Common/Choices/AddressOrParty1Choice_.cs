// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of either address, or name and address.
    /// </summary>
    [KnownType(typeof(AddressOrParty1Choice.NewAddress))]
    [KnownType(typeof(AddressOrParty1Choice.NewBeneficiary))]
    [JsonDerivedType(
        typeof(AddressOrParty1Choice.NewAddress),
        nameof(AddressOrParty1Choice.NewAddress)
    )]
    [JsonDerivedType(
        typeof(AddressOrParty1Choice.NewBeneficiary),
        nameof(AddressOrParty1Choice.NewBeneficiary)
    )]
    [IsoId("_-EhOtHltEeG7BsjMvd1mEw_136442454")]
    [DisplayName("Address Or Party 1 Choice")]
    public abstract record AddressOrParty1Choice_ { }
}
