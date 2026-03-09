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
    /// Choice of status for the affirmation.
    /// </summary>
    [KnownType(typeof(AffirmationStatus11Choice.Affirmed))]
    [KnownType(typeof(AffirmationStatus11Choice.Unaffirmed))]
    [KnownType(typeof(AffirmationStatus11Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AffirmationStatus11Choice.Affirmed),nameof(AffirmationStatus11Choice.Affirmed))]
    [JsonDerivedType(typeof(AffirmationStatus11Choice.Unaffirmed),nameof(AffirmationStatus11Choice.Unaffirmed))]
    [JsonDerivedType(typeof(AffirmationStatus11Choice.ProprietaryStatus),nameof(AffirmationStatus11Choice.ProprietaryStatus))]
    #endif
    [IsoId("_XiELhQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Affirmation Status 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AffirmationStatus11Choice_
    #else
    public abstract partial class AffirmationStatus11Choice_
    #endif
    {
    }
}
