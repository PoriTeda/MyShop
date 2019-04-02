using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ProductDataAccess;
using System.Threading;

namespace MyShop.Controllers
{
    public class ProductsController : ApiController
    {
        

        // GET api/Products

        
        public IEnumerable<MATHANG> Get()
        {
            
            
            using(ShopDBEntities db = new ShopDBEntities())
            {
                return db.MATHANGs.ToList();
            }
            
        }
        
        
            
        // GET api/Products/5
        public MATHANG Get(int id)
        {
            using (ShopDBEntities db = new ShopDBEntities())
            {
                return db.MATHANGs.FirstOrDefault(p=>p.MaHang==id);
            }
        }

        public HttpResponseMessage Post([FromBody] MATHANG employee)
        {
            try
            {
                using (ShopDBEntities db = new ShopDBEntities())
                {
                    db.MATHANGs.Add(employee);
                    db.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                    message.Headers.Location = new Uri(Request.RequestUri + employee.MaHang.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (ShopDBEntities db = new ShopDBEntities())
                {
                    var entity = db.MATHANGs.FirstOrDefault(x => x.MaHang == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "MATHANG with ID " + id.ToString() + " not found to delete");

                    }
                    else
                    {
                        db.MATHANGs.Remove(entity);
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }

                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }

        public HttpResponseMessage Put(int id, [FromBody] MATHANG product)
        {
            try
            {
                using (ShopDBEntities db = new ShopDBEntities())
                {

                    var entity = db.MATHANGs.FirstOrDefault(e => e.MaHang == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "MATHANG with ID " + id.ToString() + " not found to update");
                    }
                    else
                    {
                        entity.TenHang = product.TenHang;
                        entity.Size = product.Size;
                        entity.Giaban = product.Giaban;
                        entity.Mota = product.Mota;
                        entity.AnhMH = product.AnhMH;
                        entity.Ngaycapnhat = product.Ngaycapnhat;
                        entity.Soluongton = product.Soluongton;
                        entity.MaLoai = product.MaLoai;
                        entity.MaTH = product.MaTH;
                        entity.MaXuHuong = product.MaXuHuong;
                        


                        db.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, entity);

                    }
                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }
    }
}