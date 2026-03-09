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
    /// Specifies the identification of the relevant supervising authority.
    /// </summary>
    [KnownType(typeof(SupervisingAuthorityIdentification1Choice.ProprietaryIdentification))]
    [KnownType(typeof(SupervisingAuthorityIdentification1Choice.FullName))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SupervisingAuthorityIdentification1Choice.ProprietaryIdentification),nameof(SupervisingAuthorityIdentification1Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(SupervisingAuthorityIdentification1Choice.FullName),nameof(SupervisingAuthorityIdentification1Choice.FullName))]
    #endif
    [IsoId("_4ZQrMPH-Eeaz_YGUGLjP6A")]
    [DisplayName("Supervising Authority Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SupervisingAuthorityIdentification1Choice_
    #else
    public abstract partial class SupervisingAuthorityIdentification1Choice_
    #endif
    {
    }
}
