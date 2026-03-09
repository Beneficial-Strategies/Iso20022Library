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
    /// Choice between a code and a data source scheme to specify the type of alternate identification.
    /// </summary>
    [KnownType(typeof(IdentificationType43Choice.Code))]
    [KnownType(typeof(IdentificationType43Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IdentificationType43Choice.Code),nameof(IdentificationType43Choice.Code))]
    [JsonDerivedType(typeof(IdentificationType43Choice.Proprietary),nameof(IdentificationType43Choice.Proprietary))]
    #endif
    [IsoId("_gWRMa4MEEeWhGPRU7TIQwQ")]
    [DisplayName("Identification Type 43 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationType43Choice_
    #else
    public abstract partial class IdentificationType43Choice_
    #endif
    {
    }
}
