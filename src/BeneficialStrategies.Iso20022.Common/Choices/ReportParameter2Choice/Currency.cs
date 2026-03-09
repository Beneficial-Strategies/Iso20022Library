// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.ReportParameter2Choice
{
    /// <summary>
    /// Currency for which the estimated cash flow is being reported.
    /// </summary>
    [IsoId("_U1-1gtp-Ed-ak6NoX_4Aeg_-922147042")]
    [DisplayName("Currency")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Currency : ReportParameter2Choice_
    #else
    public partial class Currency : ReportParameter2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Currency instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Currency( string reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// A code allocated to a currency by a Maintenance Agency under an international identification scheme, as described in the latest edition of the international standard ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ccy")]
        #endif
        [IsoXmlTag("Ccy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveOrHistoricCurrencyCode Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string Value { get; init; } 
        #else
        public string Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
