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
namespace BeneficialStrategies.Iso20022.Choices.ClearingExceptionOrExemption3Choice
{
    /// <summary>
    /// Set of information specific to counterparties.
    /// </summary>
    [IsoId("_AjSxc5PuEey0rJ3Gl6WZVA")]
    [DisplayName("Counterparties")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Counterparties : ClearingExceptionOrExemption3Choice_
    #else
    public partial class Counterparties : ClearingExceptionOrExemption3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Counterparties instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Counterparties( NonClearingReason2 reqReportingCounterparty )
        {
            ReportingCounterparty = reqReportingCounterparty;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifies the type of clearing exemption or exception that the reporting counterparty has elected.
        /// </summary>
        [IsoId("_Ak0bcZPuEey0rJ3Gl6WZVA")]
        [DisplayName("Reporting Counterparty")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RptgCtrPty")]
        #endif
        [IsoXmlTag("RptgCtrPty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NonClearingReason2 ReportingCounterparty { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required NonClearingReason2 ReportingCounterparty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NonClearingReason2 ReportingCounterparty { get; init; } 
        #else
        public NonClearingReason2 ReportingCounterparty { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the type of clearing exemption or exception that the other counterparty has elected.
        /// </summary>
        [IsoId("_Ak0bc5PuEey0rJ3Gl6WZVA")]
        [DisplayName("Other Counterparty")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OthrCtrPty")]
        #endif
        [IsoXmlTag("OthrCtrPty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public NonClearingReason2? OtherCounterparty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NonClearingReason2? OtherCounterparty { get; init; } 
        #else
        public NonClearingReason2? OtherCounterparty { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
