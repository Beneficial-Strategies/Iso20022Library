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
    /// Choice of either address, or name and address.
    /// </summary>
    [KnownType(typeof(AddressOrParty1Choice.NewAddress))]
    [KnownType(typeof(AddressOrParty1Choice.NewBeneficiary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AddressOrParty1Choice.NewAddress),nameof(AddressOrParty1Choice.NewAddress))]
    [JsonDerivedType(typeof(AddressOrParty1Choice.NewBeneficiary),nameof(AddressOrParty1Choice.NewBeneficiary))]
    #endif
    [IsoId("_-EhOtHltEeG7BsjMvd1mEw_136442454")]
    [DisplayName("Address Or Party 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AddressOrParty1Choice_
    #else
    public abstract partial class AddressOrParty1Choice_
    #endif
    {
    }
}
