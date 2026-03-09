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
    /// Choice of format for the affirmation status.
    /// </summary>
    [KnownType(typeof(AffirmationStatus7Choice.Code))]
    [KnownType(typeof(AffirmationStatus7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AffirmationStatus7Choice.Code),nameof(AffirmationStatus7Choice.Code))]
    [JsonDerivedType(typeof(AffirmationStatus7Choice.Proprietary),nameof(AffirmationStatus7Choice.Proprietary))]
    #endif
    [IsoId("_A6DC4NokEeC60axPepSq7g_711252739")]
    [DisplayName("Affirmation Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AffirmationStatus7Choice_
    #else
    public abstract partial class AffirmationStatus7Choice_
    #endif
    {
    }
}
