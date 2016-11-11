using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Engines
{
   public class DataEngine
    {
        #region Connection
        SqlConnection conn;
        SqlConnectionStringBuilder connStringBuilder;
        public void ConnectTo()
        {
            //Data Source=CHRISTIE-PC\SQLEXPRESS;Initial Catalog=dbNewAge;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "CHRISTIE-PC\\SQLEXPRESS";
            connStringBuilder.InitialCatalog = "dbNewAge";
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
        }
        public DataEngine()
        {
            ConnectTo();
        }
        #endregion Connection

        #region Select
        /// <summary>
        /// Select all materialTypes
        /// </summary>
        /// <returns>Material Types </returns>
        public List<Accessor.MaterialTypes> GetMaterialTypes()
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                var Query = from m in dc.tblMaterialTypes
                            select new Accessor.MaterialTypes
                            {
                                TypeID = m.TypeID,
                                MeasureType = m.MeasureType
                            };
                return Query.ToList();
            }
        }

        /// <summary>
        /// Select all Materials and MeasureType
        /// </summary>
        /// <returns></returns>
        public List<Accessor.MaterialProperties> GetMaterial()
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                var Query = from m in dc.tblMaterials
                            join t in dc.tblMaterialTypes
                            on m.TypeID equals t.TypeID
                            select new Accessor.MaterialProperties
                            {
                                MaterialID = m.MaterialID,
                                MaterialName = m.Name,
                                Destcription = m.Description,
                                MaterialType = t.MeasureType
                            };
                return Query.ToList();
            }
        }

        public static tblMaterial GetMaterial(string materialID)
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                return (from ord in dc.GetTable<tblMaterial>()
                        where ord.MaterialID == materialID
                        select ord).SingleOrDefault<tblMaterial>();
            }
        }
        /// <summary>
        /// Select the LengthCost by materialID
        /// </summary>
        /// <returns></returns>
        public List<Accessor.LengthAccess> GetLength()
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                var Query = from m in dc.tblLengthCosts
                            join k in dc.tblMaterials
                            on m.MaterialID equals k.MaterialID
                            select new Accessor.LengthAccess
                            {

                                MaterialName = k.Name,
                                LengthCostID = m.LenghtCostID,
                                Description = k.Description,
                                MaterialID = m.MaterialID,
                                NumPieces = m.NoPieces,
                                TotalLength = m.TotalLength,
                                LengthPerPiece = m.LengthPerPiece,
                                TotalCost = m.TotalCostPieces,
                                PricePerMeter = m.PricePerMeter
                            };
                return Query.ToList();
            }
        }

        public static tblLengthCost GetLengthPricePerMeter(String materialID)
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                return (from ord in dc.GetTable<tblLengthCost>()
                        where ord.MaterialID == materialID
                        select ord).SingleOrDefault<tblLengthCost>();
            }
        }
        /// <summary>
        /// Sekects the AreaCost by MaterialID
        /// </summary>
        /// <returns></returns>
        public List<Accessor.AreaAccess> GetArea()
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                var Query = from m in dc.tblAreaCosts
                            join k in dc.tblMaterials
                            on m.MaterialID equals k.MaterialID
                            select new Accessor.AreaAccess
                            {
                                AreaCostID = m.AreatCostID,
                                MaterialID = m.MaterialID,
                                MaterialName = k.Name,
                                Description = k.Description,
                                TotalLenght = m.TotalLenght,
                                TotalWidth = m.TotalWidth,
                                TotalCost = m.TotalCost,
                                PricePSqrMeter = m.PricePerMeterSQ,
                                TotalArea = m.TotalArea
                            };
                return Query.ToList();
            }
        }

        /// <summary>
        /// Sekects the Volume by MaterialID
        /// </summary>
        /// <returns></returns>
        public List<Accessor.VolumeAccess> GetVolume()
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                var Query = from m in dc.tblVolumeCosts
                            join k in dc.tblMaterials
                            on m.MaterialID equals k.MaterialID
                            select new Accessor.VolumeAccess
                            {
                                VolumeCostID = m.VolumeCostID,
                                MaterialID = m.MaterialID,
                                MaterialName = k.Name,
                                Description = k.Description,
                                TotalVolume = m.TotalVolume,
                                TotalCost = m.TotalCost,
                                PricePerLitre = m.PricePerLiter
                            };
                return Query.ToList();
            }
        }

        /// <summary>
        /// Sekects the BussinessCost by MaterialID
        /// </summary>
        /// <returns></returns>
        public List<Accessor.BussinessCost> GetBusCost()
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                var Query = from m in dc.tblBussinessCosts
                            join k in dc.tblMaterials
                            on m.MaterialID equals k.MaterialID
                            select new Accessor.BussinessCost
                            {
                                BussinessCostID = m.BussinessCostID,
                                MaterialID = m.MaterialID,
                                MaterialName = k.Name,
                                Description = k.Description,
                                CostName = m.CostName,
                                RatePerHour = m.RatePerHour,
                            };
                return Query.ToList();
            }



        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matID"></param>
        /// <param name="frameType"></param>
        /// <returns></returns>
        public static List<Accessor.AtlanticCanvasLenght> GetAtlanticLength(int frameType)
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                var Query = from n in dc.tblAtlanticCanvasLengths
                            join m in dc.tblMaterials
                            on n.MaterialID equals m.MaterialID
                            where n.FrameID == frameType
                            select new Accessor.AtlanticCanvasLenght
                            {
                                MaterialID = n.MaterialID,
                                MaterialName = m.Name,
                                FrameID = n.FrameID,
                                FrameLenght = n.FrameLenght,
                                FrameWidth = n.FrameWidth,
                                NoOfFrames = n.NoOfFrames,
                                TotalUsedFrameCost = n.TotalUsedFrameCost,
                                TotalArea = n.FrameArea,
                                CanvasOverlap = n.CanvasOverlap,
                                TotalCanvasArea = n.TotalCanvasArea,
                                TotalFrameLength = n.TotalFrameLength
                            };
                return Query.ToList();
            }
        }
        /// <summary>
        /// Return single Record
        /// </summary>
        /// <param name="frameType"></param>
        /// <param name="materialID"></param>
        /// <returns></returns>
        public static tblAtlanticCanvasLength GetAtlanticLength(int frameType, String materialID)
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                return (from ord in dc.GetTable<tblAtlanticCanvasLength>()
                        join m in dc.tblMaterials
                        on ord.MaterialID equals m.MaterialID
                        where ord.FrameID == frameType && ord.MaterialID == materialID
                        select ord).SingleOrDefault< tblAtlanticCanvasLength>();
            }
        }

        public static tblAtlanticCanvasArea GetAtlanticArea(String materialID)
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                return (from ord in dc.GetTable<tblAtlanticCanvasArea>()
                        join m in dc.tblMaterials
                        on ord.MaterialID equals m.MaterialID
                        where ord.MaterialID == materialID
                        select ord).SingleOrDefault<tblAtlanticCanvasArea>();
            }
        }

        #endregion Select

        #region Insert

        /// <summary>
        /// Save the Material and also a blank entry for the corresponding cost centre 
        /// </summary>
        /// <param name="m"></param>
        /// <param name="type"></param>
        public void SaveMaterial(Accessor.MaterialProperties m, int type)
        {

            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                tblMaterial mat = new tblMaterial
                {
                    MaterialID = m.MaterialID,
                    Name = m.MaterialName,
                    Description = m.Destcription,
                    TypeID = m.TypeID
                };

                dc.tblMaterials.InsertOnSubmit(mat);
                try
                {
                    dc.SubmitChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                switch (type)
                {
                    #region Length
                    case 1:
                        tblLengthCost l = new tblLengthCost
                        {
                            TypeID = 1,
                            MaterialID = m.MaterialID,
                            NoPieces = 0,
                            TotalLength = 0,
                            LengthPerPiece = 0,
                            TotalCostPieces = 0,
                            PricePerMeter = 0
                        };
                        dc.tblLengthCosts.InsertOnSubmit(l);
                        try
                        {
                            dc.SubmitChanges();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                       
                        break;
                    #endregion Length

                    #region Area
                    case 2:
                        tblAreaCost a = new tblAreaCost
                        {
                            TypeID = 2,
                            MaterialID = m.MaterialID,
                            TotalLenght = 0,
                            TotalWidth = 0,
                            TotalCost = 0,
                            PricePerMeterSQ = 0,
                            TotalArea = 0
                        };
                        dc.tblAreaCosts.InsertOnSubmit(a);
                        try
                        {
                            dc.SubmitChanges();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        break;
                    #endregion Area

                    #region Volume
                    case 3:
                        tblVolumeCost v = new tblVolumeCost
                        {
                            TypeID = 3,
                            MaterialID = m.MaterialID,
                            TotalVolume = 0,
                            TotalCost = 0,
                            PricePerLiter = 0
                        };
                        dc.tblVolumeCosts.InsertOnSubmit(v);
                        try
                        {
                            dc.SubmitChanges();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        break;
                    #endregion Volume

                    #region BussinessCost
                    case 4:
                        tblBussinessCost b = new tblBussinessCost
                        {
                            TypeID = 4,
                            MaterialID = m.MaterialID,
                            CostName = m.MaterialName,
                            RatePerHour = 0,

                        };
                        dc.tblBussinessCosts.InsertOnSubmit(b);
                        try
                        {
                            dc.SubmitChanges();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        break;
                    #endregion BussinessCost

                    //TODO FINISH INSERT
                    default:
                        break;
                }
            }


        }

        /// <summary>
        /// select the length entry by id and update the record
        /// </summary>
        /// <param name="LenID"></param>
        /// <param name="m"></param>
        public void SaveLength(int LenID, Accessor.LengthAccess m)
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                var matched = (from l in dc.tblLengthCosts
                               where l.LenghtCostID == LenID
                               select l).SingleOrDefault();
                try
                {
                    matched.NoPieces = m.NumPieces;
                    matched.TotalLength = m.TotalLength;
                    matched.LengthPerPiece = m.LengthPerPiece;
                    matched.TotalCostPieces = m.TotalCost;
                    matched.PricePerMeter = m.PricePerMeter;

                    dc.SubmitChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// select the Area entry by id and update the record
        /// </summary>
        /// <param name="AreaID"></param>
        /// <param name="m"></param>
        public void SaveArea(int AreaID, Accessor.AreaAccess m)
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                var matched = (from l in dc.tblAreaCosts
                               where l.AreatCostID == AreaID
                               select l).SingleOrDefault();
                try
                {
                    matched.TotalLenght = m.TotalLenght;
                    matched.TotalWidth = m.TotalWidth;
                    matched.TotalCost = m.TotalCost;
                    matched.PricePerMeterSQ = m.PricePSqrMeter;
                    matched.TotalArea = m.TotalArea;

                    dc.SubmitChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// select the volume entry by id and update the record
        /// </summary>
        /// <param name="VolID"></param>
        /// <param name="m"></param>
        public void SaveVolume(int VolID, Accessor.VolumeAccess m)
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                var matched = (from l in dc.tblVolumeCosts
                               where l.VolumeCostID == VolID
                               select l).SingleOrDefault();
                try
                {
                    matched.TotalVolume = m.TotalVolume;
                    matched.TotalCost = m.TotalCost;
                    matched.PricePerLiter = m.PricePerLitre;

                    dc.SubmitChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="BusID"></param>
        /// <param name="m"></param>
        public void SaveBussinessCost(int BusID, Accessor.BussinessCost m)
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                var matched = (from l in dc.tblBussinessCosts
                               where l.BussinessCostID == BusID
                               select l).SingleOrDefault();
                try
                {
                    matched.RatePerHour = m.RatePerHour;

                    dc.SubmitChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public void SaveAtlanticLength(int AtLenID, Accessor.AtlanticCanvasLenght m)
        {
            using (LinqtoNewAgeDataContext dc = new LinqtoNewAgeDataContext())
            {
                var matched = (from l in dc.tblAtlanticCanvasLengths
                               where l.AtlanticCanvasLenID== AtLenID
                               select l).SingleOrDefault();
                try
                {
                    matched.FrameLenght = m.FrameLenght;
                    matched.FrameWidth = m.FrameWidth;
                    matched.NoOfFrames = m.NoOfFrames;
                    matched.TotalUsedFrameCost = m.TotalUsedFrameCost;
                    matched.FrameArea = m.TotalArea;
                    matched.CanvasOverlap = m.CanvasOverlap;
                    matched.TotalCanvasArea = m.TotalCanvasArea;
                    matched.TotalFrameLength = m.TotalFrameLength;

                    dc.SubmitChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        #endregion Insert

        //TODO Create Delete Method
        #region Delete
        #endregion Delete

        #region PrimaryKey
        public string GenerateKeyMaterial(string sName)
        {
            // The string Name that the Primary key will be generated form
            string sNumber = "1";
            string sPrimaryKey = "";
            string sKeyCheck = "";

            sName = sName.Substring(0, 3);
            sNumber = sNumber.PadLeft(3, '0');
            sPrimaryKey = sName.ToUpper() + sNumber;
            List<String> columnData = new List<String>();
            int intCounter = 0;
            try
            {
                string cmdText = "SELECT * FROM [dbo].[tblMaterial] WHERE MaterialID LIKE @ID";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                string ID = "%" + sName + "%";
                cmd.Parameters.AddWithValue("@ID", ID);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    columnData.Add(reader["MaterialID"].ToString());
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            foreach (string child in columnData)
            {
                sKeyCheck = child;
                do
                {
                    string strKeyChecker = sKeyCheck;
                    strKeyChecker = strKeyChecker.Substring(3, 3);
                    intCounter++;
                    sNumber = intCounter.ToString();

                    sPrimaryKey = sName.ToUpper() + sNumber.PadLeft(3, '0');
                } while (sKeyCheck == sPrimaryKey);
            }
            return sPrimaryKey;
        }

        #endregion PrimaryKey

    }
}
