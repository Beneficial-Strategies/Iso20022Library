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
    /// Choice of format for option party.
    /// </summary>
    [KnownType(typeof(OptionParty2Choice.Code))]
    [KnownType(typeof(OptionParty2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionParty2Choice.Code),nameof(OptionParty2Choice.Code))]
    [JsonDerivedType(typeof(OptionParty2Choice.Proprietary),nameof(OptionParty2Choice.Proprietary))]
    #endif
    [IsoId("_4RufoeLaEeWFtOV72FbX9w")]
    [DisplayName("Option Party 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionParty2Choice_
    #else
    public abstract partial class OptionParty2Choice_
    #endif
    {
    }
}
