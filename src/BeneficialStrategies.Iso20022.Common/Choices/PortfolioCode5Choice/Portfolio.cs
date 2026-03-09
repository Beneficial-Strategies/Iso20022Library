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
namespace BeneficialStrategies.Iso20022.Choices.PortfolioCode5Choice
{
    /// <summary>
    /// Unique code determined by the reporting counterparty to identify the portfolio if collateral is reported on a portfolio basis.
    /// </summary>
    [IsoId("_wnwasTICEe2fXedS_ucFOA")]
    [DisplayName("Portfolio")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Portfolio : PortfolioCode5Choice_
    #else
    public partial class Portfolio : PortfolioCode5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Portfolio instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Portfolio( System.String reqCode )
        {
            Code = reqCode;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique code determined by the reporting counterparty to identify the portfolio if collateral is reported on a portfolio basis.
        /// </summary>
        [IsoId("_B1XWMTIDEe2fXedS_ucFOA")]
        [DisplayName("Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cd")]
        #endif
        [IsoXmlTag("Cd")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax52Text Code { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Code { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Code { get; init; } 
        #else
        public System.String Code { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the collateral portfolio includes transactions exempt from reporting.
        /// Usage: If the element is not present, the PortfolioTransactionExemption is False.
        /// </summary>
        [IsoId("_B1X9QTIDEe2fXedS_ucFOA")]
        [DisplayName("Portfolio Transaction Exemption")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtflTxXmptn")]
        #endif
        [IsoXmlTag("PrtflTxXmptn")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoTrueFalseIndicator? PortfolioTransactionExemption { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PortfolioTransactionExemption { get; init; } 
        #else
        public System.String? PortfolioTransactionExemption { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
