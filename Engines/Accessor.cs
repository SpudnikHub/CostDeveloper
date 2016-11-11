using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engines
{
    public class Accessor
    {
        public class MaterialProperties : Accessor
        {
            string materialID;
            string materialName;
            string destcription;
            int typeID;
            string materialType;

            public String MaterialID
            {
                get
                {
                    return materialID;
                }

                set
                {
                    materialID = value;
                }
            }

            public String MaterialName
            {
                get
                {
                    return materialName;
                }

                set
                {
                    materialName = value;
                }
            }

            public String Destcription
            {
                get
                {
                    return destcription;
                }

                set
                {
                    destcription = value;
                }
            }

            public Int32 TypeID
            {
                get
                {
                    return typeID;
                }

                set
                {
                    typeID = value;
                }
            }

            public String MaterialType
            {
                get
                {
                    return materialType;
                }

                set
                {
                    materialType = value;
                }
            }
            public override string ToString()
            {
                return materialName;
            }
        }

        public class MaterialTypes
        {
            int typeID;
            string measureType;

            public int TypeID
            {
                get
                {
                    return typeID;
                }

                set
                {
                    typeID = value;
                }
            }

            public string MeasureType
            {
                get
                {
                    return measureType;
                }

                set
                {
                    measureType = value;
                }
            }
            public override string ToString()
            {
                return measureType;
            }
        }

        public class LengthAccess : Accessor
        {
            int lengthCostID;
            int typeID;
            string materialID;
            string materialName;
            string description;
            System.Nullable<decimal> numPieces;
            System.Nullable<decimal> totalLength;
            System.Nullable<decimal> lengthPerPiece;
            System.Nullable<decimal> totalCost;
            System.Nullable<decimal> pricePerMeter;

            public Int32 LengthCostID
            {
                get
                {
                    return lengthCostID;
                }

                set
                {
                    lengthCostID = value;
                }
            }

            public Int32 TypeID
            {
                get
                {
                    return typeID;
                }

                set
                {
                    typeID = value;
                }
            }

            public String MaterialID
            {
                get
                {
                    return materialID;
                }

                set
                {
                    materialID = value;
                }
            }

            public System.Nullable<decimal> NumPieces
            {
                get
                {
                    return numPieces;
                }

                set
                {
                    numPieces = value;
                }
            }

            public System.Nullable<decimal> TotalLength
            {
                get
                {
                    return totalLength;
                }

                set
                {
                    totalLength = value;
                }
            }

            public System.Nullable<decimal> LengthPerPiece
            {
                get
                {
                    return lengthPerPiece;
                }

                set
                {
                    lengthPerPiece = value;
                }
            }

            public System.Nullable<decimal> TotalCost
            {
                get
                {
                    return totalCost;
                }

                set
                {
                    totalCost = value;
                }
            }

            public System.Nullable<decimal> PricePerMeter
            {
                get
                {
                    return pricePerMeter;
                }

                set
                {
                    pricePerMeter = value;
                }
            }

            public String MaterialName
            {
                get
                {
                    return materialName;
                }

                set
                {
                    materialName = value;
                }
            }

            public String Description
            {
                get
                {
                    return description;
                }

                set
                {
                    description = value;
                }
            }
            public override String ToString()
            {
                return materialName;
            }
        }

        public class AreaAccess
        {
            int areaCostID;
            int typeID;
            string materialID;
            string materialName;
            string description;
            decimal? totalLenght;
            decimal? totalWidth;
            decimal? totalCost;
            decimal? pricePSqrMeter;
            decimal? totalArea;

            public Int32 AreaCostID
            {
                get
                {
                    return areaCostID;
                }

                set
                {
                    areaCostID = value;
                }
            }

            public Int32 TypeID
            {
                get
                {
                    return typeID;
                }

                set
                {
                    typeID = value;
                }
            }

            public String MaterialID
            {
                get
                {
                    return materialID;
                }

                set
                {
                    materialID = value;
                }
            }

            public String MaterialName
            {
                get
                {
                    return materialName;
                }

                set
                {
                    materialName = value;
                }
            }

            public String Description
            {
                get
                {
                    return description;
                }

                set
                {
                    description = value;
                }
            }

            public Decimal? TotalLenght
            {
                get
                {
                    return totalLenght;
                }

                set
                {
                    totalLenght = value;
                }
            }

            public Decimal? TotalWidth
            {
                get
                {
                    return totalWidth;
                }

                set
                {
                    totalWidth = value;
                }
            }

            public Decimal? TotalCost
            {
                get
                {
                    return totalCost;
                }

                set
                {
                    totalCost = value;
                }
            }

            public Decimal? PricePSqrMeter
            {
                get
                {
                    return pricePSqrMeter;
                }

                set
                {
                    pricePSqrMeter = value;
                }
            }

            public Decimal? TotalArea
            {
                get
                {
                    return totalArea;
                }

                set
                {
                    totalArea = value;
                }
            }
            public override String ToString()
            {
                return materialName;
            }

        }

        public class VolumeAccess
        {
            int volumeCostID;
            int typeID;
            string materialID;
            string materialName;
            string description;
            decimal? totalVolume;
            decimal? totalCost;
            decimal? pricePerLitre;

            public Int32 TypeID
            {
                get
                {
                    return typeID;
                }

                set
                {
                    typeID = value;
                }
            }

            public String MaterialID
            {
                get
                {
                    return materialID;
                }

                set
                {
                    materialID = value;
                }
            }

            public String MaterialName
            {
                get
                {
                    return materialName;
                }

                set
                {
                    materialName = value;
                }
            }

            public String Description
            {
                get
                {
                    return description;
                }

                set
                {
                    description = value;
                }
            }

            public Int32 VolumeCostID
            {
                get
                {
                    return volumeCostID;
                }

                set
                {
                    volumeCostID = value;
                }
            }

            public Decimal? TotalVolume
            {
                get
                {
                    return totalVolume;
                }

                set
                {
                    totalVolume = value;
                }
            }

            public Decimal? TotalCost
            {
                get
                {
                    return totalCost;
                }

                set
                {
                    totalCost = value;
                }
            }

            public Decimal? PricePerLitre
            {
                get
                {
                    return pricePerLitre;
                }

                set
                {
                    pricePerLitre = value;
                }
            }
            public override String ToString()
            {
                return materialName;
            }
        }

        public class BussinessCost
        {
            int bussinessCostID;
            int typeID;
            string materialID;
            string materialName;
            string description;
            string costName;
            decimal? ratePerHour;

            public Int32 BussinessCostID
            {
                get
                {
                    return bussinessCostID;
                }

                set
                {
                    bussinessCostID = value;
                }
            }

            public Int32 TypeID
            {
                get
                {
                    return typeID;
                }

                set
                {
                    typeID = value;
                }
            }

            public String MaterialID
            {
                get
                {
                    return materialID;
                }

                set
                {
                    materialID = value;
                }
            }

            public String CostName
            {
                get
                {
                    return costName;
                }

                set
                {
                    costName = value;
                }
            }

            public Decimal? RatePerHour
            {
                get
                {
                    return ratePerHour;
                }

                set
                {
                    ratePerHour = value;
                }
            }

            public String MaterialName
            {
                get
                {
                    return materialName;
                }

                set
                {
                    materialName = value;
                }
            }

            public String Description
            {
                get
                {
                    return description;
                }

                set
                {
                    description = value;
                }
            }

            public override String ToString()
            {
                return MaterialName;
            }
        }

        public class AtlanticCanvasLenght
        {
            int  atlanticCanvasLenID;
            string materialID;
            string materialName;
            string description;
            int frameID;
            string frameType;
            decimal? frameLenght;
            decimal? frameWidth;
            decimal? noOfFrames;
            decimal? totalFrameCost;
            decimal? totalUsedFrameCost;
            decimal? totalArea;
            decimal? canvasOverlap;
            decimal? totalCanvasArea;
            decimal? totalFrameLength;

            public Int32 AtlanticCanvasLenID
            {
                get
                {
                    return atlanticCanvasLenID;
                }

                set
                {
                    atlanticCanvasLenID = value;
                }
            }

            public String MaterialID
            {
                get
                {
                    return materialID;
                }

                set
                {
                    materialID = value;
                }
            }

            public Decimal? FrameLenght
            {
                get
                {
                    return frameLenght;
                }

                set
                {
                    frameLenght = value;
                }
            }

            public Decimal? FrameWidth
            {
                get
                {
                    return frameWidth;
                }

                set
                {
                    frameWidth = value;
                }
            }

            public Decimal? NoOfFrames
            {
                get
                {
                    return noOfFrames;
                }

                set
                {
                    noOfFrames = value;
                }
            }

            public Decimal? TotalFrameCost
            {
                get
                {
                    return totalFrameCost;
                }

                set
                {
                    totalFrameCost = value;
                }
            }

            public Decimal? TotalUsedFrameCost
            {
                get
                {
                    return totalUsedFrameCost;
                }

                set
                {
                    totalUsedFrameCost = value;
                }
            }

            public Decimal? TotalArea
            {
                get
                {
                    return totalArea;
                }

                set
                {
                    totalArea = value;
                }
            }

            public Decimal? CanvasOverlap
            {
                get
                {
                    return canvasOverlap;
                }

                set
                {
                    canvasOverlap = value;
                }
            }

            public Decimal? TotalCanvasArea
            {
                get
                {
                    return totalCanvasArea;
                }

                set
                {
                    totalCanvasArea = value;
                }
            }

            public Decimal? TotalFrameLength
            {
                get
                {
                    return totalFrameLength;
                }

                set
                {
                    totalFrameLength = value;
                }
            }

            public String MaterialName
            {
                get
                {
                    return materialName;
                }

                set
                {
                    materialName = value;
                }
            }

            public String Description
            {
                get
                {
                    return description;
                }

                set
                {
                    description = value;
                }
            }

            public Int32 FrameID
            {
                get
                {
                    return frameID;
                }

                set
                {
                    frameID = value;
                }
            }

            public String FrameType
            {
                get
                {
                    return frameType;
                }

                set
                {
                    frameType = value;
                }
            }

            public override String ToString()
            {
                return MaterialName;
            }

        }
        public class AtlanticCanvasLenghtSingle
        {
            int atlanticCanvasLenID;
            string materialID;
            string materialName;
            string description;
            int frameID;
            string frameType;
            decimal? frameLenght;
            decimal? frameWidth;
            decimal? noOfFrames;
            decimal? totalFrameCost;
            decimal? totalUsedFrameCost;
            decimal? totalArea;
            decimal? canvasOverlap;
            decimal? totalCanvasArea;
            decimal? totalFrameLength;

            public Int32 AtlanticCanvasLenID
            {
                get
                {
                    return atlanticCanvasLenID;
                }

                set
                {
                    atlanticCanvasLenID = value;
                }
            }

            public String MaterialID
            {
                get
                {
                    return materialID;
                }

                set
                {
                    materialID = value;
                }
            }

            public Decimal? FrameLenght
            {
                get
                {
                    return frameLenght;
                }

                set
                {
                    frameLenght = value;
                }
            }

            public Decimal? FrameWidth
            {
                get
                {
                    return frameWidth;
                }

                set
                {
                    frameWidth = value;
                }
            }

            public Decimal? NoOfFrames
            {
                get
                {
                    return noOfFrames;
                }

                set
                {
                    noOfFrames = value;
                }
            }

            public Decimal? TotalFrameCost
            {
                get
                {
                    return totalFrameCost;
                }

                set
                {
                    totalFrameCost = value;
                }
            }

            public Decimal? TotalUsedFrameCost
            {
                get
                {
                    return totalUsedFrameCost;
                }

                set
                {
                    totalUsedFrameCost = value;
                }
            }

            public Decimal? TotalArea
            {
                get
                {
                    return totalArea;
                }

                set
                {
                    totalArea = value;
                }
            }

            public Decimal? CanvasOverlap
            {
                get
                {
                    return canvasOverlap;
                }

                set
                {
                    canvasOverlap = value;
                }
            }

            public Decimal? TotalCanvasArea
            {
                get
                {
                    return totalCanvasArea;
                }

                set
                {
                    totalCanvasArea = value;
                }
            }

            public Decimal? TotalFrameLength
            {
                get
                {
                    return totalFrameLength;
                }

                set
                {
                    totalFrameLength = value;
                }
            }

            public String MaterialName
            {
                get
                {
                    return materialName;
                }

                set
                {
                    materialName = value;
                }
            }

            public String Description
            {
                get
                {
                    return description;
                }

                set
                {
                    description = value;
                }
            }

            public Int32 FrameID
            {
                get
                {
                    return frameID;
                }

                set
                {
                    frameID = value;
                }
            }

            public String FrameType
            {
                get
                {
                    return frameType;
                }

                set
                {
                    frameType = value;
                }
            }

            public override String ToString()
            {
                return MaterialName;
            }

        }

    }
}
