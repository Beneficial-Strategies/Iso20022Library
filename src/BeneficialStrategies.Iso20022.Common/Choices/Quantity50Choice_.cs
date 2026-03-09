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
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity50Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity50Choice.SignedQuantity))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Quantity50Choice.OriginalAndCurrentFaceAmount),nameof(Quantity50Choice.OriginalAndCurrentFaceAmount))]
    [JsonDerivedType(typeof(Quantity50Choice.SignedQuantity),nameof(Quantity50Choice.SignedQuantity))]
    #endif
    [IsoId("_K-7tVRuyEeyhRdHRjakS2w")]
    [DisplayName("Quantity 50 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Quantity50Choice_
    #else
    public abstract partial class Quantity50Choice_
    #endif
    {
    }
}
