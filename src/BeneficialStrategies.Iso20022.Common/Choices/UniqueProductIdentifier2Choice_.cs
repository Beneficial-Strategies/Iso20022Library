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
    /// Element is a choice between a standard identifier and a proprietary code.
    /// </summary>
    [KnownType(typeof(UniqueProductIdentifier2Choice.Identification))]
    [KnownType(typeof(UniqueProductIdentifier2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UniqueProductIdentifier2Choice.Identification),nameof(UniqueProductIdentifier2Choice.Identification))]
    [JsonDerivedType(typeof(UniqueProductIdentifier2Choice.Proprietary),nameof(UniqueProductIdentifier2Choice.Proprietary))]
    #endif
    [IsoId("__zlGkWETEe2P-L9DBerEgA")]
    [DisplayName("Unique Product Identifier 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UniqueProductIdentifier2Choice_
    #else
    public abstract partial class UniqueProductIdentifier2Choice_
    #endif
    {
    }
}
