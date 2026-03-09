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
    /// Charge is expressed as a code or a bilaterally agreed code.
    /// </summary>
    [KnownType(typeof(ChargeTypeChoice.Code))]
    [KnownType(typeof(ChargeTypeChoice.ProprietaryCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChargeTypeChoice.Code),nameof(ChargeTypeChoice.Code))]
    [JsonDerivedType(typeof(ChargeTypeChoice.ProprietaryCode),nameof(ChargeTypeChoice.ProprietaryCode))]
    #endif
    [IsoId("_RIcz1Np-Ed-ak6NoX_4Aeg_-1267403817")]
    [DisplayName("Charge Type Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeTypeChoice_
    #else
    public abstract partial class ChargeTypeChoice_
    #endif
    {
    }
}
