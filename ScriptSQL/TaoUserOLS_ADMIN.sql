--Tạo user OLS_ADMIN ở PDB 
alter user lbacsys identified by lbacsys account unlock;

create user OLS_ADMIN identified by 123 container = current;
grant connect, resource to admin_ols;
grant unlimited tablespace to admin_ols;
grant select any dictionary to admin_ols;
grant execute on lbacsys.sa_components to admin_ols with grant option; 
grant execute on lbacsys.sa_user_admin to admin_ols with grant option; 
grant execute on lbacsys.sa_label_admin to admin_ols with grant option; 
grant execute on sa_policy_admin to admin_ols with grant option; 
grant execute on char_to_label to admin_ols with grant option; 

grant lbac_dba to OLS_ADMIN;
grant execute on sa_sysdba to OLS_ADMIN; 
grant execute on to_lbac_data_label to OLS_ADMIN;
