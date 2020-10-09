# FactoryPattern

Šioje programoje turime 4 figūras, stačiakampį, kvadratą ir jų apvalias versijas. Yra dvi gamyklos, viena sukuria kampuotas figūras, kita apvalias. Taip pat yra gamyklų gamykla, kuri sukuria vieną iš jų. Čia panaudojame abstrakčios gamyklos dizaino modelį. Jis leis ateityje lengvai didinti mūsų programą. Atsiradus poreikiui pridėti dar vieną gamyklą(pvz. iškreipta), mes tai galima padaryti neliesdami kitų klasių logikos. Tą patį galime padaryti ir su naujom figūrom.
