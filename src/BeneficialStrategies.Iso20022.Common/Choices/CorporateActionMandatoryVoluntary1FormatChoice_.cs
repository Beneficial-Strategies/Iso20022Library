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
    /// Choice of formats to express whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [KnownType(typeof(CorporateActionMandatoryVoluntary1FormatChoice.Code))]
    [KnownType(typeof(CorporateActionMandatoryVoluntary1FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionMandatoryVoluntary1FormatChoice.Code),nameof(CorporateActionMandatoryVoluntary1FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionMandatoryVoluntary1FormatChoice.Proprietary),nameof(CorporateActionMandatoryVoluntary1FormatChoice.Proprietary))]
    #endif
    [IsoId("_RmZ7Itp-Ed-ak6NoX_4Aeg_1296355739")]
    [DisplayName("Corporate Action Mandatory Voluntary 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionMandatoryVoluntary1FormatChoice_
    #else
    public abstract partial class CorporateActionMandatoryVoluntary1FormatChoice_
    #endif
    {
    }
}
