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
    /// Specifies the charge type.
    /// </summary>
    [KnownType(typeof(ChargeType2Choice.Code))]
    [KnownType(typeof(ChargeType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChargeType2Choice.Code),nameof(ChargeType2Choice.Code))]
    [JsonDerivedType(typeof(ChargeType2Choice.Proprietary),nameof(ChargeType2Choice.Proprietary))]
    #endif
    [IsoId("_RvC5w9p-Ed-ak6NoX_4Aeg_-1781938940")]
    [DisplayName("Charge Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeType2Choice_
    #else
    public abstract partial class ChargeType2Choice_
    #endif
    {
    }
}
