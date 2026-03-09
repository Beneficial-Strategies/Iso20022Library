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
    [KnownType(typeof(AffirmationStatus6Choice.Affirmed))]
    [KnownType(typeof(AffirmationStatus6Choice.Unaffirmed))]
    [KnownType(typeof(AffirmationStatus6Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AffirmationStatus6Choice.Affirmed),nameof(AffirmationStatus6Choice.Affirmed))]
    [JsonDerivedType(typeof(AffirmationStatus6Choice.Unaffirmed),nameof(AffirmationStatus6Choice.Unaffirmed))]
    [JsonDerivedType(typeof(AffirmationStatus6Choice.ProprietaryStatus),nameof(AffirmationStatus6Choice.ProprietaryStatus))]
    #endif
    [IsoId("_A55R5NokEeC60axPepSq7g_-1061221633")]
    [DisplayName("Affirmation Status 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AffirmationStatus6Choice_
    #else
    public abstract partial class AffirmationStatus6Choice_
    #endif
    {
    }
}
