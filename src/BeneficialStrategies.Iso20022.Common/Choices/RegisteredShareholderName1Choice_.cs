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
    /// Choice of individual or organisation name and address.
    /// </summary>
    [KnownType(typeof(RegisteredShareholderName1Choice.IndividualPerson))]
    [KnownType(typeof(RegisteredShareholderName1Choice.Organisation))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RegisteredShareholderName1Choice.IndividualPerson),nameof(RegisteredShareholderName1Choice.IndividualPerson))]
    [JsonDerivedType(typeof(RegisteredShareholderName1Choice.Organisation),nameof(RegisteredShareholderName1Choice.Organisation))]
    #endif
    [IsoId("_ijIuEFxYEeWvPv3PXpS3fw")]
    [DisplayName("Registered Shareholder Name 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RegisteredShareholderName1Choice_
    #else
    public abstract partial class RegisteredShareholderName1Choice_
    #endif
    {
    }
}
