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
    /// Choice between a central securities depositary or a national central bank for querying party reference data.
    /// </summary>
    [KnownType(typeof(CSDOrNCB1Choice.CSDIdentification))]
    [KnownType(typeof(CSDOrNCB1Choice.NCBIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CSDOrNCB1Choice.CSDIdentification),nameof(CSDOrNCB1Choice.CSDIdentification))]
    [JsonDerivedType(typeof(CSDOrNCB1Choice.NCBIdentification),nameof(CSDOrNCB1Choice.NCBIdentification))]
    #endif
    [IsoId("_knY98O5NEeCisYr99QEiWA_761515761")]
    [DisplayName("CSD Or NCB 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CSDOrNCB1Choice_
    #else
    public abstract partial class CSDOrNCB1Choice_
    #endif
    {
    }
}
