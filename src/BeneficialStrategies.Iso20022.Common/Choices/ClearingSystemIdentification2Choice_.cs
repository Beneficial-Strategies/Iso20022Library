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
    /// Choice of a clearing system identifier.
    /// </summary>
    [KnownType(typeof(ClearingSystemIdentification2Choice.Code))]
    [KnownType(typeof(ClearingSystemIdentification2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClearingSystemIdentification2Choice.Code),nameof(ClearingSystemIdentification2Choice.Code))]
    [JsonDerivedType(typeof(ClearingSystemIdentification2Choice.Proprietary),nameof(ClearingSystemIdentification2Choice.Proprietary))]
    #endif
    [IsoId("_TMoSENp-Ed-ak6NoX_4Aeg_-1410917193")]
    [DisplayName("Clearing System Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClearingSystemIdentification2Choice_
    #else
    public abstract partial class ClearingSystemIdentification2Choice_
    #endif
    {
    }
}
