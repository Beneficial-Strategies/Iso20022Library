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
    /// Classification of a master agreement.
    /// </summary>
    [KnownType(typeof(AgreementType2Choice.Type))]
    [KnownType(typeof(AgreementType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AgreementType2Choice.Type),nameof(AgreementType2Choice.Type))]
    [JsonDerivedType(typeof(AgreementType2Choice.Proprietary),nameof(AgreementType2Choice.Proprietary))]
    #endif
    [IsoId("_Nw6gQS4yEeuxhbw_aW6haw")]
    [DisplayName("Agreement Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AgreementType2Choice_
    #else
    public abstract partial class AgreementType2Choice_
    #endif
    {
    }
}
