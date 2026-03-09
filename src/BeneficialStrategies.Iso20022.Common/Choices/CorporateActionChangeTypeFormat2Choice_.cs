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
    /// Choice between a standard code or a proprietary code to specify a type of change.
    /// </summary>
    [KnownType(typeof(CorporateActionChangeTypeFormat2Choice.Code))]
    [KnownType(typeof(CorporateActionChangeTypeFormat2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionChangeTypeFormat2Choice.Code),nameof(CorporateActionChangeTypeFormat2Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionChangeTypeFormat2Choice.Proprietary),nameof(CorporateActionChangeTypeFormat2Choice.Proprietary))]
    #endif
    [IsoId("_Qzl-Itp-Ed-ak6NoX_4Aeg_-953922271")]
    [DisplayName("Corporate Action Change Type Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionChangeTypeFormat2Choice_
    #else
    public abstract partial class CorporateActionChangeTypeFormat2Choice_
    #endif
    {
    }
}
