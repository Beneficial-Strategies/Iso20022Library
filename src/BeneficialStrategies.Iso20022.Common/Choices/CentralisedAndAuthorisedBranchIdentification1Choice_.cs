// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifiers for the central and authorised branches.
    /// </summary>
    [KnownType(typeof(CentralisedAndAuthorisedBranchIdentification1Choice.AuthorisedBranchIdentifier))]
    [KnownType(typeof(CentralisedAndAuthorisedBranchIdentification1Choice.CentralisedBranchIdentifiers))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CentralisedAndAuthorisedBranchIdentification1Choice.AuthorisedBranchIdentifier),nameof(CentralisedAndAuthorisedBranchIdentification1Choice.AuthorisedBranchIdentifier))]
    [JsonDerivedType(typeof(CentralisedAndAuthorisedBranchIdentification1Choice.CentralisedBranchIdentifiers),nameof(CentralisedAndAuthorisedBranchIdentification1Choice.CentralisedBranchIdentifiers))]
    #endif
    [IsoId("_4ju2EB9pEeapDZRA0Hb6ow")]
    [DisplayName("Centralised And Authorised Branch Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CentralisedAndAuthorisedBranchIdentification1Choice_
    #else
    public abstract partial class CentralisedAndAuthorisedBranchIdentification1Choice_
    #endif
    {
    }
}
