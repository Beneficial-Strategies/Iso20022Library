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
    /// Specifies the removal processing change requested and the reason.
    /// </summary>
    [KnownType(typeof(RemovalProcessing2Choice.FinancialInstrumentIdentification))]
    [KnownType(typeof(RemovalProcessing2Choice.IndexIdentification))]
    [KnownType(typeof(RemovalProcessing2Choice.IssuerCountry))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RemovalProcessing2Choice.FinancialInstrumentIdentification),nameof(RemovalProcessing2Choice.FinancialInstrumentIdentification))]
    [JsonDerivedType(typeof(RemovalProcessing2Choice.IndexIdentification),nameof(RemovalProcessing2Choice.IndexIdentification))]
    [JsonDerivedType(typeof(RemovalProcessing2Choice.IssuerCountry),nameof(RemovalProcessing2Choice.IssuerCountry))]
    #endif
    [IsoId("__MbGwRIoEeyZaPkaPAzTvQ")]
    [DisplayName("Removal Processing 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RemovalProcessing2Choice_
    #else
    public abstract partial class RemovalProcessing2Choice_
    #endif
    {
    }
}
