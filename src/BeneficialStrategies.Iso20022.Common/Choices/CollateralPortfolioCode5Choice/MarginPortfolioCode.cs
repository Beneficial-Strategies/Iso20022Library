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
namespace BeneficialStrategies.Iso20022.Choices.CollateralPortfolioCode5Choice
{
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the margin portfolio if the collateral is posted on a margin portfolio basis.
    /// </summary>
    [IsoId("_YxDO0zIDEe2fXedS_ucFOA")]
    [DisplayName("Margin Portfolio Code")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MarginPortfolioCode : CollateralPortfolioCode5Choice_
    #else
    public partial class MarginPortfolioCode : CollateralPortfolioCode5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MarginPortfolioCode instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MarginPortfolioCode( PortfolioCode5Choice_ reqInitialMarginPortfolioCode )
        {
            InitialMarginPortfolioCode = reqInitialMarginPortfolioCode;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
        /// Usage:
        /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
        /// </summary>
        [IsoId("_tnypoTICEe2fXedS_ucFOA")]
        [DisplayName("Initial Margin Portfolio Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InitlMrgnPrtflCd")]
        #endif
        [IsoXmlTag("InitlMrgnPrtflCd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PortfolioCode5Choice_ InitialMarginPortfolioCode { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PortfolioCode5Choice_ InitialMarginPortfolioCode { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PortfolioCode5Choice_ InitialMarginPortfolioCode { get; init; } 
        #else
        public PortfolioCode5Choice_ InitialMarginPortfolioCode { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
        /// Usage:
        /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
        /// </summary>
        [IsoId("_tnypozICEe2fXedS_ucFOA")]
        [DisplayName("Variation Margin Portfolio Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VartnMrgnPrtflCd")]
        #endif
        [IsoXmlTag("VartnMrgnPrtflCd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PortfolioCode5Choice_? VariationMarginPortfolioCode { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PortfolioCode5Choice_? VariationMarginPortfolioCode { get; init; } 
        #else
        public PortfolioCode5Choice_? VariationMarginPortfolioCode { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
