// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifiers for the central and authorised branches.
    /// </summary>
    [KnownType(typeof(CentralisedAndAuthorisedBranchIdentification1Choice.AuthorisedBranchIdentifier))]
    [KnownType(typeof(CentralisedAndAuthorisedBranchIdentification1Choice.CentralisedBranchIdentifiers))]
    [JsonDerivedType(typeof(CentralisedAndAuthorisedBranchIdentification1Choice.AuthorisedBranchIdentifier),nameof(CentralisedAndAuthorisedBranchIdentification1Choice.AuthorisedBranchIdentifier))]
    [JsonDerivedType(typeof(CentralisedAndAuthorisedBranchIdentification1Choice.CentralisedBranchIdentifiers),nameof(CentralisedAndAuthorisedBranchIdentification1Choice.CentralisedBranchIdentifiers))]
    [IsoId("_4ju2EB9pEeapDZRA0Hb6ow")]
    [DisplayName("Centralised And Authorised Branch Identification 1 Choice")]
    public abstract partial record CentralisedAndAuthorisedBranchIdentification1Choice_
    {
    }
}
