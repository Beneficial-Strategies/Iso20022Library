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
    /// Specifies the choice between the listed and the proprietary error codes.
    /// </summary>
    [KnownType(typeof(ErrorHandling3Choice.Code))]
    [KnownType(typeof(ErrorHandling3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ErrorHandling3Choice.Code),nameof(ErrorHandling3Choice.Code))]
    [JsonDerivedType(typeof(ErrorHandling3Choice.Proprietary),nameof(ErrorHandling3Choice.Proprietary))]
    #endif
    [IsoId("_RA_79XhdEeidzqjNEfehPg")]
    [DisplayName("Error Handling 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ErrorHandling3Choice_
    #else
    public abstract partial class ErrorHandling3Choice_
    #endif
    {
    }
}
