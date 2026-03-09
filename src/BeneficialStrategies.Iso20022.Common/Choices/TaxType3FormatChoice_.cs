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
    /// Choice of formats to express the type of taxes.
    /// </summary>
    [KnownType(typeof(TaxType3FormatChoice.Code))]
    [KnownType(typeof(TaxType3FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxType3FormatChoice.Code),nameof(TaxType3FormatChoice.Code))]
    [JsonDerivedType(typeof(TaxType3FormatChoice.Proprietary),nameof(TaxType3FormatChoice.Proprietary))]
    #endif
    [IsoId("_RpFbsdp-Ed-ak6NoX_4Aeg_215638433")]
    [DisplayName("Tax Type 3 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxType3FormatChoice_
    #else
    public abstract partial class TaxType3FormatChoice_
    #endif
    {
    }
}
