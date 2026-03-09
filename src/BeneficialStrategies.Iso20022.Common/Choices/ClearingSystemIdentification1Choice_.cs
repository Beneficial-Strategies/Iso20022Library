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
    /// Information used to identify a cash clearing system.
    /// </summary>
    [KnownType(typeof(ClearingSystemIdentification1Choice.ClearingSystemIdentification))]
    [KnownType(typeof(ClearingSystemIdentification1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClearingSystemIdentification1Choice.ClearingSystemIdentification),nameof(ClearingSystemIdentification1Choice.ClearingSystemIdentification))]
    [JsonDerivedType(typeof(ClearingSystemIdentification1Choice.Proprietary),nameof(ClearingSystemIdentification1Choice.Proprietary))]
    #endif
    [IsoId("_TMLmMNp-Ed-ak6NoX_4Aeg_-1061546408")]
    [DisplayName("Clearing System Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClearingSystemIdentification1Choice_
    #else
    public abstract partial class ClearingSystemIdentification1Choice_
    #endif
    {
    }
}
