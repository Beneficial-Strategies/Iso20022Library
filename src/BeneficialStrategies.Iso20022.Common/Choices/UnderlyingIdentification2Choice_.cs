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
    /// Details of the underlying of a security transaction.
    /// </summary>
    [KnownType(typeof(UnderlyingIdentification2Choice.Swap))]
    [KnownType(typeof(UnderlyingIdentification2Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnderlyingIdentification2Choice.Swap),nameof(UnderlyingIdentification2Choice.Swap))]
    [JsonDerivedType(typeof(UnderlyingIdentification2Choice.Other),nameof(UnderlyingIdentification2Choice.Other))]
    #endif
    [IsoId("_Ko9qBYG-EeaalK9UbuVGFw")]
    [DisplayName("Underlying Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnderlyingIdentification2Choice_
    #else
    public abstract partial class UnderlyingIdentification2Choice_
    #endif
    {
    }
}
